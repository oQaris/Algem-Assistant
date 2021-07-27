using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Algem
{
    public partial class Form1 : Form
    {
        int MOD = 0;
        int section = 1;
        string BufPoly = String.Empty;
        char x = 'x';

        public Form1()
        {
            InitializeComponent();
        }

        private void FindPrimesAtkin(int limit, out bool[] IsPrimes)
        {
            IsPrimes = new bool[limit + 1];
            double sqrt = Math.Sqrt(limit);
            if (sqrt < 29301)
            {
                for (int x = 1; x <= sqrt; x++)
                    for (int y = 1; y <= sqrt; y++)
                    {
                        int x2 = x * x;
                        int y2 = y * y;
                        int n = 4 * x2 + y2;
                        if (n <= limit && (n % 12 == 1 || n % 12 == 5))
                            IsPrimes[n] ^= true;

                        n -= x2;
                        if (n <= limit && n % 12 == 7)
                            IsPrimes[n] ^= true;

                        n -= 2 * y2;
                        if (x > y && n <= limit && n % 12 == 11)
                            IsPrimes[n] ^= true;
                    }

                for (int n = 5; n <= sqrt; n += 2)
                    if (IsPrimes[n])
                    {
                        int s = n * n;
                        for (int k = s; k <= limit; k += s)
                            IsPrimes[k] = false;
                    }
            }
            else
            {
                var lim = (ulong)limit;
                for (ulong x = 1; x <= sqrt; x++)
                    for (ulong y = 1; y <= sqrt; y++)
                    {
                        ulong x2 = x * x;
                        ulong y2 = y * y;
                        ulong n = 4 * x2 + y2;
                        if (n <= lim && (n % 12 == 1 || n % 12 == 5))
                            IsPrimes[n] ^= true;

                        n -= x2;
                        if (n <= lim && n % 12 == 7)
                            IsPrimes[n] ^= true;

                        n -= 2 * y2;
                        if (x > y && n <= lim && n % 12 == 11)
                            IsPrimes[n] ^= true;
                    }

                for (ulong n = 5; n <= sqrt; n += 2)
                    if (IsPrimes[n])
                    {
                        ulong s = n * n;
                        for (ulong k = s; k <= lim; k += s)
                            IsPrimes[k] = false;
                    }
            }
            IsPrimes[2] = true;
            IsPrimes[3] = true;
        }

        void FindPrimesEratosthenes(int limit, out bool[] IsPrimes)
        {
            // limit - максимальное число; IsPrimes - массив, где
            // true - число вычеркнуто, false - не вычеркнуто(т.е.простое)

            IsPrimes = new bool[limit + 1]; // по умолчанию инициализируется false
            IsPrimes[0] = true;
            IsPrimes[1] = true;

            // перебираем до корня из limit включительно
            int n = Convert.ToInt32(Math.Sqrt(limit));
            for (int i = 2; i <= n; i++)
            {
                // если i - простое (не вычеркнуто)
                if (!IsPrimes[i])
                {
                    // то вычеркнем кратные i
                    for (int k = i + i; k <= limit; k += i)
                        IsPrimes[k] = true;
                }
            }
        }

        bool IsPrimeNum(int num)
        {
            if (num == 2)
                return true;
            if (num < 2 || num % 2 == 0)
                return false;
            int n = Convert.ToInt32(Math.Sqrt(num));
            for (int i = 3; i <= n; i += 2)
                if (num % i == 0)
                    return false;
            return true;
        }

        int GCDnum(int a, int b)
        {
            if (a * b == 0) // если одно из чисел 0
                return a + b; // то возвращаем другое число (0 + a = a)
            if (a < b)
                return GCDnum(a, b % a); // рекурсивно вызываем НОД для 1-го числа и остатка от деления 2-го числа на 1-е
            else
                return GCDnum(a % b, b); // рекурсивно вызываем НОД для 2-го числа и остатка от деления 1-го числа на 2-е
        }

        int InverseResidue(int num, int mod)
        {
            num %= mod;
            // приводим к положительному
            if (num < 0)
                num += mod;
            // ищем такое число, чтоб при уножении на num давало 1
            for (int i = 1; i < mod; i++)
                if (num * i % mod == 1)
                    return i;
            return 0;
        }

        void Derivative(ref double[] poly)
        {
            double[] der = new double[poly.Length - 1];
            for (int i = poly.Length - 1; i > 0; i--)
                der[i - 1] = poly[i] * i;
            poly = der;
        }

        void Derivative(ref int[] poly, int mod)
        {
            int[] der = new int[poly.Length - 1];
            for (int i = poly.Length - 1; i > 0; i--)
                der[i - 1] = (poly[i] * i) % mod;
            poly = der;
        }

        void Sum(double[] poly1, double[] poly2, out double[] sum)
        {
            int n;
            if (poly1.Length < poly2.Length)
            {
                n = poly1.Length;
                sum = (double[])poly2.Clone();
                for (int i = 0; i < n; i++)
                    sum[i] += poly1[i];
            }
            else
            {
                n = poly2.Length;
                sum = (double[])poly1.Clone();
                for (int i = 0; i < n; i++)
                    sum[i] += poly2[i];
            }
        }

        void Sum(int[] poly1, int[] poly2, out int[] sum, int mod)
        {
            int n;
            if (poly1.Length < poly2.Length)
            {
                n = poly1.Length;
                sum = (int[])poly2.Clone();
                for (int i = 0; i < n; i++)
                {
                    sum[i] += poly1[i];
                    sum[i] %= mod;
                }
            }
            else
            {
                n = poly2.Length;
                sum = (int[])poly1.Clone();
                for (int i = 0; i < n; i++)
                {
                    sum[i] += poly2[i];
                    sum[i] %= mod;
                }
            }
        }

        void Conv(double[] mn1, double[] mn2, out double[] prod)
        {
            int len1 = mn1.Length;
            int len2 = mn2.Length;
            prod = new double[len1 + len2 - 1];
            for (int i = 0; i < len1; i++)
                for (int j = 0; j < len2; j++)
                    prod[i + j] += mn1[i] * mn2[j];
        }

        void Conv(int[] mn1, int[] mn2, out int[] prod, int mod)
        {
            int len1 = mn1.Length;
            int len2 = mn2.Length;
            prod = new int[len1 + len2 - 1];
            for (int i = 0; i < len1; i++)
                for (int j = 0; j < len2; j++)
                    prod[i + j] += mn1[i] * mn2[j];
        }

        void Deconv(double[] dividend, double[] divisor, out double[] quotient, out double[] remainder)
        {
            // если последний элемент в массиве равен нулю, то выдаём исключение
            if (dividend.Last() == 0)
                throw new ArithmeticException("Старший член многочлена делимого не может быть 0");
            if (divisor.Last() == 0)
                throw new ArithmeticException("Старший член многочлена делителя не может быть 0");
            // если количество элементов в массиве f меньше чем в массиве g
            if (dividend.Length < divisor.Length)
                throw new ArithmeticException("Степень многочлена делимого не может быть меньше многочлена делителя");

            remainder = (double[])dividend.Clone(); // в массив остатка копируем элементы из массива делимого
            quotient = new double[remainder.Length - divisor.Length + 1]; // выделяем память для массива частного
            int dlen = divisor.Length;
            int rlen = remainder.Length;
            int qlen = quotient.Length;
            double coeff;
            for (int i = 0; i < qlen; i++)
            {
                coeff = remainder[rlen - i - 1] / divisor.Last(); // считаем коэффициент для домножения
                quotient[qlen - i - 1] = coeff; // вставляем его в массив частного
                for (int j = 0; j < dlen; j++)
                {
                    // делитель домножаем на коэффициент и вычитаем из делимного, это и есть остаток
                    remainder[rlen - i - j - 1] -= coeff * divisor[dlen - j - 1];
                }
            }
        }

        void Deconv(int[] dividend, int[] divisor, out int[] quotient, out int[] remainder, int mod)
        {

            for (int i = 0; i < dividend.Length; i++)
                dividend[i] %= mod;
            for (int i = 0; i < divisor.Length; i++)
                divisor[i] %= mod;

            if (dividend.Last() == 0)
                throw new ArithmeticException("Старший член многочлена делимого не может быть 0");
            if (divisor.Last() == 0)
                throw new ArithmeticException("Старший член многочлена делителя не может быть 0");
            if (dividend.Length < divisor.Length)
                throw new ArithmeticException("Степень многочлена делимого не может быть меньше многочлена делителя");

            remainder = (int[])dividend.Clone();
            quotient = new int[remainder.Length - divisor.Length + 1];
            int dlen = divisor.Length;
            int rlen = remainder.Length;
            int qlen = quotient.Length;
            int coeff;
            for (int i = 0; i < qlen; i++)
            {
                coeff = (remainder[rlen - i - 1] * InverseResidue(divisor.Last(), mod)) % mod;
                quotient[qlen - i - 1] = coeff;
                for (int j = 0; j < dlen; j++)
                {
                    remainder[rlen - i - j - 1] -= coeff * divisor[dlen - j - 1];
                    remainder[rlen - i - j - 1] %= mod;
                }
            }
        }

        void GCDpoly(double[] poly1, double[] poly2, out double[] gcd)
        {
            // выделяем память для массива результата (столько же мест, как у многочлена наименьшей степени)
            gcd = new double[poly1.Length < poly2.Length ? poly1.Length : poly2.Length];
            double[] rem; // массив остатка

            // если какой то многочлен нулевой, то НОД - другой многочлен
            if (isEmpty(poly1))
                gcd = poly2;
            else if (isEmpty(poly2))
                gcd = poly1;

            else if (poly1.Length < poly2.Length)
            {
                Deconv(poly2, poly1, out _, out rem); // делим многочлены (out _ - значит, нам не важно частное, только остаток)
                clipp(ref rem); // обрезаем старшие нулевые степени у остатка
                GCDpoly(poly1, rem, out gcd); // рекурсивно вызываем функцию
            }
            else
            {
                // всё то же самое, только делим мн./чл. 1 на мн./чл. 2
                Deconv(poly1, poly2, out _, out rem);
                clipp(ref rem);
                GCDpoly(rem, poly2, out gcd);
            }
        }

        void GCDpoly(int[] poly1, int[] poly2, out int[] gcd, int mod)
        {
            gcd = new int[poly1.Length < poly2.Length ? poly1.Length : poly2.Length];
            int[] rem;

            if (isEmpty(poly1))
                gcd = poly2;
            else if (isEmpty(poly2))
                gcd = poly1;

            else if (poly1.Length < poly2.Length)
            {
                Deconv(poly2, poly1, out _, out rem, mod);
                clipp(ref rem);
                GCDpoly(poly1, rem, out gcd, mod);
            }
            else
            {
                Deconv(poly1, poly2, out _, out rem, mod);
                clipp(ref rem);
                GCDpoly(rem, poly2, out gcd, mod);
            }
        }

        void procZero(ref int[] mn, int mod)
        {
            procPlus(ref mn, mod);
            for (int i = 0; i < mn.Length; i++)
                if (Math.Abs(mn[i]) > Math.Abs(mn[i] - mod))
                    mn[i] -= mod;
        }

        void procPlus(ref int[] mn, int mod)
        {
            for (int i = 0; i < mn.Length; i++)
            {
                mn[i] %= mod;
                mn[i] += mod;
                mn[i] %= mod;
            }
        }

        bool isEmpty(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
                if (mas[i] != 0)
                    return false;
            return true;
        }
        bool isEmpty(double[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
                if (Math.Abs(mas[i]) > 1E-9)
                    return false;
            return true;
        }

        void clipp<T>(ref T[] poly) where T : IComparable<T>
        {
            int count = 0;
            for (int i = poly.Length - 1; i >= 0; i--)
                if (poly[i].CompareTo(default(T)) == 0)
                    count++;
                else
                    break;
            T[] buf = new T[poly.Length - count];
            for (int i = 0; i < buf.Length; i++)
                buf[i] = poly[i];
            poly = buf;
        }

        int AliquotPoly(int[] poly, double root, int mod)
        {
            double buf = 0;
            for (int i = 0; i < poly.Length; i++)
                buf += poly[i] * Math.Pow(root, i);
            if (Math.Abs(mod != 0 ? buf % mod : buf) < 1E-9)
            {
                int aliquot = 0;
                double[] polyBuf = Array.ConvertAll(poly, x => (double)x);
                double[] polyRoot = new double[] { -1 * root, 1 };
                while (true)
                {
                    Deconv(polyBuf, polyRoot, out double[] quot, out double[] rem);
                    if (mod != 0)
                        for (int i = 0; i < rem.Length; i++)
                            rem[i] %= mod;
                    if (isEmpty(rem) && quot.Length > 1)
                    {
                        aliquot++;
                        polyBuf = quot;
                    }
                    else
                        break;
                }
                return aliquot;
            }
            else
                return 0;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            switch (section)
            {
                case 1:
                    if (!backgroundWorker1.IsBusy)
                        PrimeNumInterface();
                    else
                    {
                        backgroundWorker1.CancelAsync();
                        MessageBox.Show("Вычисление простых чисел не было завершено!\nБыло выполнено только " + (100 * progressBar1.Value / progressBar1.Maximum).ToString() + "%\nПоследнее простое число " + listBox1.Items[listBox1.Items.Count - 1].ToString(), "Досрочная отмена операции", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case 2:
                    RevResInterface();
                    break;

                case 5:
                    RootsPolyInterface();
                    break;

                case 6:
                    DivPolyInterface();
                    break;

                case 7:
                    GCDpolyInterface();
                    break;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (section == 4)
                SumProizPolyInterface("sum");
            else
                GCDorGCMnumInterface("GCD");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (section == 4)
                SumProizPolyInterface("prod");
            else
                GCDorGCMnumInterface("GCM");
        }

        private void PrimeNumInterface()
        {
            try
            {
                if (textBox5.Text.ToString().Length == 0)
                    throw new FormatException("Последовательность не содержит элементов");
                int num = Convert.ToInt32(textBox5.Text);
                if (num < 2)
                    throw new FormatException("Минимально возможное число: 2");

                btnCalc.Text = "Отмена";
                textBox5.ReadOnly = true;
                listBox1.Items.Clear();
                progressBar1.Maximum = num;
                if (num >= 1000)
                {
                    progressBar1.Visible = true;
                }
                backgroundWorker1.RunWorkerAsync(num);

                //for (int i = 2; i <= num; i++)
                //    if (IsPrimeNum(i))
                //        listBox1.Items.Add(i);

                //FindPrimesEratosthenes(num, out bool[] prime);
                //for (int i = 0; i < prime.Length; i++)
                //    if (!prime[i])
                //        listBox1.Items.Add(i);

                //FindPrimesAtkin(num, out bool[] prime);
                //for (int i = 0; i < prime.Length; i++)
                //    if (prime[i])
                //        listBox1.Items.Add(i);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Некорректные входные значения!\n" + Convert.ToString(exp));
            }
        }

        private void RevResInterface()
        {
            try
            {
                if (textBox1.Text.ToString().Length == 0 || textBox2.Text.ToString().Length == 0)
                    throw new FormatException("Последовательность не содержит элементов");
                int num = Convert.ToInt32(textBox1.Text);
                int mod = Convert.ToInt32(textBox2.Text);
                int res = InverseResidue(num, mod);
                if (res == 0)
                    textBox3.Text = "Обратного элемента не существует!";
                else
                    textBox3.Text = res.ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Некорректные входные значения!\n" + Convert.ToString(exp));
            }
        }

        private void GCDorGCMnumInterface(string opt)
        {
            try
            {
                if (textBox1.Text.ToString().Length == 0 || textBox2.Text.ToString().Length == 0)
                    throw new FormatException("Последовательность не содержит элементов");
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);
                if (num1 == 0 && num2 == 0)
                    textBox3.Text = "infinity";
                else
                {
                    num1 = Math.Abs(num1);
                    num2 = Math.Abs(num2);
                    int gcd = GCDnum(num1, num2);

                    if (opt == "GCD")
                        textBox3.Text = gcd.ToString();
                    else if (opt == "GCM")
                        textBox3.Text = (num1 * num2 / gcd).ToString();
                    else
                        throw new FormatException("Несуществующий аргумент {opt}");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Некорректные входные значения!\n" + Convert.ToString(exp));
            }
        }

        private void SumProizPolyInterface(string opt)
        {
            try
            {
                if (MOD == 0)
                {
                    InputPoly(textBox1.Text, out double[] mn1);
                    InputPoly(textBox2.Text, out double[] mn2);
                    double[] res;
                    try
                    {
                        if (opt == "sum")
                            Sum(mn1, mn2, out res);
                        else if (opt == "prod")
                            Conv(mn1, mn2, out res);
                        else
                            throw new FormatException("Несуществующий аргумент {opt}");

                        textBox3.Text = ShowPoly(res, rbtCoef.Checked ? 1 : 2, (int)numericUpDown1.Value);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(Convert.ToString(exp));
                    }
                }
                else
                {
                    InputPoly(textBox1.Text, out int[] mn1);
                    InputPoly(textBox2.Text, out int[] mn2);
                    int[] res;
                    try
                    {
                        if (opt == "sum")
                            Sum(mn1, mn2, out res, MOD);
                        else if (opt == "prod")
                            Conv(mn1, mn2, out res, MOD);
                        else
                            throw new FormatException("Несуществующий аргумент {opt}");

                        if (rbtZero.Checked)
                            procZero(ref res, MOD);
                        else
                            procPlus(ref res, MOD);

                        textBox3.Text = ShowPoly(res, rbtCoef.Checked ? 1 : 2);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(Convert.ToString(exp));
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Некорректные значения при вводе многочлена!\n" + Convert.ToString(exp));
            }
        }

        private void RootsPolyInterface()
        {
            try
            {
                InputPoly(textBox1.Text, out int[] poly);
                listView1.Items.Clear();
                int aliquot;
                int n = poly.Length;

                try
                {
                    if (poly.Length < 2)
                        throw new FormatException("Многочлен не должен быть константой");
                    if (MOD == 0)
                    {
                        int noZeroNum = 0;
                        if (poly[0] == 0)
                        {
                            listView1.Items.Add(new ListViewItem(new string[] { "0", "1" }));
                            for (int i = poly.Length - 2; i >= 0; i--)
                                if (poly[i] != 0)
                                {
                                    noZeroNum = i;
                                    break;
                                }
                            if (noZeroNum == 0)
                                throw new FormatException("Непредвиденная ошибка");
                        }
                        for (int j = 1; j <= Math.Abs(poly[n - 1]); j++)
                        {
                            if (poly[n - 1] % j == 0)
                                for (int i = 1; i <= Math.Abs(poly[noZeroNum]); i++)
                                {
                                    if (poly[noZeroNum] % i == 0)
                                    {
                                    Start:
                                        if ((aliquot = AliquotPoly(poly, (double)i / j, MOD)) >= 1)
                                        {
                                            string[] items = new string[2];
                                            int gcd = GCDnum(Math.Abs(i), Math.Abs(j));
                                            items[0] = j / gcd == 1 ? (i / gcd).ToString() : (i / gcd).ToString() + "/" + (j / gcd).ToString() + " (≈ " + Math.Round((double)i / j, (int)numericUpDown1.Value) + ")";
                                            items[1] = aliquot.ToString();
                                            ListViewItem viewItem = new ListViewItem(items);
                                            viewItem.Name = items[0];
                                            if (!listView1.Items.ContainsKey(items[0]))
                                                listView1.Items.Add(viewItem);
                                        }
                                        i *= -1;
                                        if (i < 0)
                                            goto Start;
                                    }
                                }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                            poly[i] %= MOD;
                        if (poly[0] == 0)
                            listView1.Items.Add(new ListViewItem(new string[] { "0", "1" }));
                        for (int i = 1; i < MOD; i++)
                        {

                            if ((aliquot = AliquotPoly(poly, i, MOD)) >= 1)
                            {
                                string[] items = new string[2];
                                items[0] = i.ToString();
                                items[1] = aliquot.ToString();
                                ListViewItem viewItem = new ListViewItem(items);
                                viewItem.Name = items[0];
                                if (!listView1.Items.ContainsKey(items[0]))
                                    listView1.Items.Add(viewItem);
                            }
                        }
                    }
                    if (listView1.Items.Count == 0)
                        listView1.Items.Add("Нет рациональных корней!");
                }
                catch (Exception exp)
                {
                    MessageBox.Show(Convert.ToString(exp));
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Некорректные значения при вводе многочлена!\n" + Convert.ToString(exp));
            }
        }

        private void DivPolyInterface()
        {
            try
            {
                if (MOD == 0)
                {
                    InputPoly(textBox1.Text, out double[] dividend);
                    InputPoly(textBox2.Text, out double[] divisor);
                    try
                    {
                        Deconv(dividend, divisor, out double[] quotient, out double[] remainder);

                        textBox3.Text = ShowPoly(quotient, rbtCoef.Checked ? 1 : 2, (int)numericUpDown1.Value);
                        textBox4.Text = ShowPoly(remainder, rbtCoef.Checked ? 1 : 2, (int)numericUpDown1.Value);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(Convert.ToString(exp));
                    }
                }
                else
                {
                    InputPoly(textBox1.Text, out int[] dividend);
                    InputPoly(textBox2.Text, out int[] divisor);
                    try
                    {
                        Deconv(dividend, divisor, out int[] quotient, out int[] remainder, MOD);

                        if (rbtZero.Checked)
                        {
                            procZero(ref quotient, MOD);
                            procZero(ref remainder, MOD);
                        }
                        else
                        {
                            procPlus(ref quotient, MOD);
                            procPlus(ref remainder, MOD);
                        }
                        textBox3.Text = ShowPoly(quotient, rbtCoef.Checked ? 1 : 2);
                        textBox4.Text = ShowPoly(remainder, rbtCoef.Checked ? 1 : 2);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(Convert.ToString(exp));
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Некорректные значения при вводе многочлена!\n" + Convert.ToString(exp));
            }
        }

        private void GCDpolyInterface()
        {
            try
            {
                if (MOD == 0)
                {
                    InputPoly(textBox1.Text, out double[] mn1);
                    
                    double[] mn2;
                    if (cbxDer.Checked)
                    {
                        mn2 = (double[])mn1.Clone();
                        Derivative(ref mn2);
                    }
                    else
                        InputPoly(textBox2.Text, out mn2);

                    try
                    {
                        GCDpoly(mn1, mn2, out double[] gcd);

                        if (gcd.Length == 1)
                            textBox3.Text = "const";
                        else
                            textBox3.Text = ShowPoly(gcd, rbtCoef.Checked ? 1 : 2, (int)numericUpDown1.Value);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(Convert.ToString(exp));
                    }
                }
                else
                {
                    InputPoly(textBox1.Text, out int[] mn1);

                    int[] mn2;
                    if (cbxDer.Checked)
                    {
                        mn2 = (int[])mn1.Clone();
                        Derivative(ref mn2, MOD);
                    }
                    else
                        InputPoly(textBox2.Text, out mn2);

                    try
                    {
                        GCDpoly(mn1, mn2, out int[] gcd, MOD);

                        if (rbtZero.Checked)
                            procZero(ref gcd, MOD);
                        else
                            procPlus(ref gcd, MOD);

                        if (gcd.Length == 1)
                            textBox3.Text = "const";
                        else
                            textBox3.Text = ShowPoly(gcd, rbtCoef.Checked ? 1 : 2);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(Convert.ToString(exp));
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Некорректные значения при вводе многочлена!\n" + Convert.ToString(exp));
            }
        }
        
        private void btnPrimeNum_Click(object sender, EventArgs e)
        {
            section = 1;
            groupBox1.Visible = false;
            btnHelp.Visible = false;
            btnRevRes.Visible = false;
            btnGCDnum.Visible = false;
            btnDivPoly.Visible = false;
            btnGCDpoly.Visible = false;
            btnSumProizPoly.Visible = false;
            btnPrimeNum.Visible = false;
            btnRoots.Visible = false;
            lblHeader.Text = "Простые числа";
            lblHeader.Visible = true;

            label1.Text = "Макс. число";
            label1.Visible = true;
            textBox5.Visible = true;
            listBox1.Visible = true;
            btnMenu.Visible = true;
            btnCalc.Visible = true;

            if (backgroundWorker1.IsBusy)
            {
                progressBar1.Visible = true;
                btnCalc.Text = "Отмена";
            }
        }

        private void btnRevRes_Click(object sender, EventArgs e)
        {
            section = 2;
            groupBox1.Visible = false;
            btnHelp.Visible = false;
            btnRevRes.Visible = false;
            btnGCDnum.Visible = false;
            btnDivPoly.Visible = false;
            btnGCDpoly.Visible = false;
            btnSumProizPoly.Visible = false;
            btnPrimeNum.Visible = false;
            btnRoots.Visible = false;
            lblHeader.Text = "Обратные по модулю";
            lblHeader.Visible = true;
            label1.Text = "Число";
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Text = "Модуль";
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Text = "Обратное";
            label3.Visible = true;
            textBox3.Text = "тут будет число, обратное по заданному модулю";
            textBox3.Visible = true;
            btnMenu.Visible = true;
            btnCalc.Visible = true;
        }

        private void btnGCDnum_Click(object sender, EventArgs e)
        {
            section = 3;
            groupBox1.Visible = false;
            btnHelp.Visible = false;
            btnRevRes.Visible = false;
            btnGCDnum.Visible = false;
            btnDivPoly.Visible = false;
            btnGCDpoly.Visible = false;
            btnSumProizPoly.Visible = false;
            btnPrimeNum.Visible = false;
            btnRoots.Visible = false;
            lblHeader.Text = "НОД чисел";
            lblHeader.Visible = true;
            label1.Text = "1-е число";
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Text = "2-е число";
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Text = "НОД";
            label3.Visible = true;
            textBox3.Text = "тут будет наибольший общий делитель этих чисел";
            textBox3.Visible = true;
            btnMenu.Visible = true;
            btn1.Text = "НОД";
            btn1.Visible = true;
            btn2.Text = "НОК";
            btn2.Visible = true;
        }

        private void btnSumProizPoly_Click(object sender, EventArgs e)
        {
            section = 4;
            groupBox1.Visible = false;
            btnHelp.Visible = false;
            btnRevRes.Visible = false;
            btnGCDnum.Visible = false;
            btnDivPoly.Visible = false;
            btnGCDpoly.Visible = false;
            btnSumProizPoly.Visible = false;
            btnPrimeNum.Visible = false;
            btnRoots.Visible = false;
            lblHeader.Text = "Сумма/Произведение многочленов";
            lblHeader.Visible = true;

            label1.Text = "1 мн./чл.";
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Text = "2 мн./чл.";
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Text = "Результат";
            label3.Visible = true;
            textBox3.Text = "тут будет результат сложения/умножения";
            textBox3.Visible = true;

            label5.Text = "Многочлены вводятся, начиная со старшей степени";
            label5.Visible = true;
            cbxZ.Visible = true;
            btn1.Text = "Сложить";
            btn1.Visible = true;
            btn2.Text = "Умножить";
            btn2.Visible = true;
            btnMenu.Visible = true;
        }

        private void btnRootsPoly_Click(object sender, EventArgs e)
        {
            section = 5;
            groupBox1.Visible = false;
            btnHelp.Visible = false;
            btnRevRes.Visible = false;
            btnGCDnum.Visible = false;
            btnDivPoly.Visible = false;
            btnGCDpoly.Visible = false;
            btnSumProizPoly.Visible = false;
            btnPrimeNum.Visible = false;
            btnRoots.Visible = false;
            lblHeader.Text = "Рациональные корни многочлена";
            lblHeader.Visible = true;

            label1.Text = "Мн./чл.";
            label1.Visible = true;
            textBox1.Visible = true;
            listView1.Visible = true;

            label5.Text = "У многочлена должны быть целые коэффициенты!";
            label5.Location = new Point(118, 73);
            label5.Visible = true;
            cbxZ.Visible = true;
            btnCalc.Visible = true;
            btnMenu.Visible = true;
        }

        private void btnDivPoly_Click(object sender, EventArgs e)
        {
            section = 6;
            groupBox1.Visible = false;
            btnHelp.Visible = false;
            btnRevRes.Visible = false;
            btnGCDnum.Visible = false;
            btnDivPoly.Visible = false;
            btnGCDpoly.Visible = false;
            btnSumProizPoly.Visible = false;
            btnPrimeNum.Visible = false;
            btnRoots.Visible = false;
            lblHeader.Text = "Деление многочленов";
            lblHeader.Visible = true;

            label1.Text = "Делимое";
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Text = "Делитель";
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Text = "Частное";
            label3.Visible = true;
            textBox3.Text = "тут будет результат деления";
            textBox3.Visible = true;
            label4.Text = "Остаток";
            label4.Visible = true;
            textBox4.Text = "а здесь будет остаток от деления";
            textBox4.Visible = true;

            label5.Text = "Многочлены вводятся, начиная со старшей степени";
            label5.Visible = true;
            cbxZ.Visible = true;
            btnCalc.Visible = true;
            btnMenu.Visible = true;
        }

        private void btnGCDpoly_Click(object sender, EventArgs e)
        {
            section = 7;
            groupBox1.Visible = false;
            btnHelp.Visible = false;
            btnRevRes.Visible = false;
            btnGCDnum.Visible = false;
            btnDivPoly.Visible = false;
            btnGCDpoly.Visible = false;
            btnSumProizPoly.Visible = false;
            btnPrimeNum.Visible = false;
            btnRoots.Visible = false;
            lblHeader.Text = "НОД многочленов";
            lblHeader.Visible = true;

            label1.Text = "1 мн./чл.";
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Text = "2 мн./чл.";
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Text = "НОД";
            label3.Visible = true;
            textBox3.Text = "тут будет наибольший общий делитель мн./чл.";
            textBox3.Visible = true;

            label5.Text = "Многочлены вводятся, начиная со старшей степени";
            label5.Visible = true;
            cbxZ.Visible = true;
            cbxDer.Visible = true;
            btnCalc.Visible = true;
            btnMenu.Visible = true;
        }

        private void cbxZ_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxZ.Checked == true)
            {
                cbxDer.Location = new Point(450, 130);
                txtZ.Enabled = true;
                txtZ.Visible = true;
                btnOK.Visible = true;
            }
            else
            {
                MOD = 0;
                txtZ.Visible = false;
                btnOK.Visible = false;
                cbxDer.Location = new Point(450, 75);

                if (cbxDer.Checked == true && textBox1.Text.Length != 0)
                {
                    try
                    {
                        InputPoly(textBox1.Text, out double[] mn1);
                        double[] mn2 = (double[])mn1.Clone();

                        Derivative(ref mn2);
                        textBox2.Text = ShowPoly(mn2, rbtCoef.Checked ? 1 : 2, (int)numericUpDown1.Value);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(Convert.ToString(exp));
                    }
                }
            }
        }

        private void cbxDer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxDer.Checked == true)
                {
                    textBox2.ReadOnly = true;
                    BufPoly = textBox2.Text;
                    textBox2.Text = String.Empty;

                    if (MOD == 0)
                    {
                        InputPoly(textBox1.Text, out double[] mn1);
                        double[] mn2 = (double[])mn1.Clone();

                        Derivative(ref mn2);
                        textBox2.Text = ShowPoly(mn2, rbtCoef.Checked ? 1 : 2, (int)numericUpDown1.Value);
                    }
                    else
                    {
                        InputPoly(textBox1.Text, out int[] mn1);
                        int[] mn2 = (int[])mn1.Clone();

                        Derivative(ref mn2, MOD);
                        textBox2.Text = ShowPoly(mn2, rbtCoef.Checked ? 1 : 2);
                    }
                }
                else
                {
                    textBox2.ReadOnly = false;
                    textBox2.Text = BufPoly;
                }
            }
            catch { }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                MOD = Convert.ToInt32(txtZ.Text);
                if (MOD <= 0)
                    throw new ArithmeticException("Модуль должен быть больше 0!");
                else if (section != 5 && !IsPrimeNum(MOD))
                    throw new ArithmeticException("Модуль должен быть простым числом!");
                txtZ.Enabled = false;
                btnOK.Visible = false;
                if (cbxDer.Checked == true && section == 7)
                    try
                    {
                        textBox2.Text = String.Empty;
                        InputPoly(textBox1.Text, out int[] mn1);
                        int[] mn2 = (int[])mn1.Clone();

                        Derivative(ref mn2, MOD);
                        for (int i = mn2.Length - 1; i >= 0; i--)
                            textBox2.Text += mn2[i].ToString() + " ";
                    }
                    catch { }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Некорректные значения при вводе модуля!\n" + Convert.ToString(exp));
                MOD = 0;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MOD = 0;
            btnMenu.Visible = false;
            btnCalc.Visible = false;
            btnCalc.Text = "Рассчитать";
            btn1.Visible = false;
            btn2.Visible = false;
            progressBar1.Visible = false;
            cbxDer.Visible = false;
            cbxDer.Checked = false;
            cbxZ.Visible = false;
            cbxZ.Checked = false;
            txtZ.Visible = false;
            txtZ.Enabled = true;
            txtZ.Text = String.Empty;
            btnOK.Visible = false;
            label5.Visible = false;
            label5.Location = new Point(118, 107);
            label5.Text = String.Empty;
            listBox1.Visible = false;
            listView1.Visible = false;
            listView1.Items.Clear();

            textBox5.Visible = false;
            //textBox5.Text = String.Empty;
            textBox4.Visible = false;
            textBox4.Text = String.Empty;
            label4.Visible = false;
            label4.Text = String.Empty;
            textBox3.Visible = false;
            textBox3.Text = String.Empty;
            label3.Visible = false;
            label3.Text = String.Empty;
            textBox2.Visible = false;
            textBox2.Text = String.Empty;
            label1.Visible = false;
            label1.Text = String.Empty;
            textBox1.Visible = false;
            textBox1.Text = String.Empty;
            label2.Visible = false;
            label2.Text = String.Empty;
            lblHeader.Visible = false;
            lblHeader.Text = String.Empty;

            groupBox1.Visible = true;
            btnHelp.Visible = true;
            btnRevRes.Visible = true;
            btnGCDnum.Visible = true;
            btnDivPoly.Visible = true;
            btnGCDpoly.Visible = true;
            btnSumProizPoly.Visible = true;
            btnPrimeNum.Visible = true;
            btnRoots.Visible = true;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("QIWI - 8(933)301-50-70\nWebMoney - R268187608830\nЯндекс.Деньги - 410013813360449", "Поддержка проекта", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ChangedText(section);
            if (cbxDer.Checked == true && section == 7)
                try
                {
                    textBox2.Text = String.Empty;
                    if (MOD == 0)
                    {
                        InputPoly(textBox1.Text, out double[] mn1);
                        double[] mn2 = (double[])mn1.Clone();

                        Derivative(ref mn2);
                        textBox2.Text = ShowPoly(mn2, rbtCoef.Checked ? 1 : 2, (int)numericUpDown1.Value);
                    }
                    else
                    {
                        InputPoly(textBox1.Text, out int[] mn1);
                        int[] mn2 = (int[])mn1.Clone();

                        Derivative(ref mn2, MOD);
                        textBox2.Text = ShowPoly(mn2, rbtCoef.Checked ? 1 : 2);
                    }
                }
                catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ChangedText(section);
        }

        void ChangedText(int sec)
        {
            switch (section)
            {
                case 2:
                    textBox3.Text = "тут будет число, обратное по заданному модулю";
                    break;

                case 3:
                    textBox3.Text = "тут будет наибольший общий делитель этих чисел";
                    break;

                case 4:
                    textBox3.Text = "тут будет результат сложения/умножения";
                    break;

                case 6:
                    textBox3.Text = "тут будет результат деления";
                    textBox4.Text = "а здесь будет остаток от деления";
                    break;

                case 7:
                    textBox3.Text = "тут будет наибольший общий делитель мн./чл.";
                    break;
            }
        }

        void InputPoly(string s, out double[] poly)
        {
            if (s.Length == 0)
                throw new FormatException("Последовательность не содержит элементов");
            bool flag = false;
            foreach (char c in s)
                if (Char.IsLetter(c))
                {
                    x = c;
                    flag = true;
                    break;
                }
            string[] monoms;
            if (flag)
            {
                s = s.Replace(" ", String.Empty);
                s = s.Replace("*", String.Empty);
                s = s.Replace("×", String.Empty);
                s = s.Replace("⋅", String.Empty);
                foreach (char c in s)
                    if (Char.IsLetter(c) && c != x)
                        throw new FormatException("Невозможно использование нескольких переменных");

                poly = new double[maxDeg(s) + 1];

                //Regex rgx = new Regex(@"\d(?=[+-])");
                //MatchCollection collect = rgx.Matches(s);
                //if (collect.Count>0)
                //{
                //    foreach (Match mat in collect)
                //        // действия
                //}

                string num = String.Empty;
                int deg = 0;
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (Char.IsDigit(s[i]))
                        num += s[i];
                    else if (s[i] == ',' || s[i] == '.')
                        num += ',';
                    else if (s[i] == x && num == String.Empty)
                    {
                        if (i == s.Length - 1 || s[i + 1] != '^')
                            deg = 1;
                    }
                    else if (s[i] == '^' && num != String.Empty)
                    {
                        deg = Convert.ToInt32(Reverse(num));
                        num = String.Empty;
                    }
                    else if (s[i] == '+' || s[i] == '-')
                    {
                        if (num != String.Empty)
                            poly[deg] += Convert.ToDouble(Reverse(num += s[i]));
                        else
                            poly[deg] += s[i] == '-' ? -1 : 1;
                        num = String.Empty;
                        deg = 0;
                    }
                    else
                        throw new FormatException("Невозможно распознать многочлен");
                }
                if (num != String.Empty)
                    poly[deg] += Convert.ToDouble(Reverse(num));
                else if (s[0] == x)
                    poly[deg] += 1;
            }
            else
            {
                monoms = s.Split(new char[] { ' ', '\n', '\t', '+' }, StringSplitOptions.RemoveEmptyEntries);
                poly = new double[monoms.Length];
                for (int i = poly.Length - 1; i >= 0; i--)
                    poly[i] = Convert.ToDouble(monoms[poly.Length - 1 - i]);
            }
            clipp(ref poly);
            if (isEmpty(poly))
                throw new FormatException("Многочлен не должен быть нулевым");
        }

        void InputPoly(string s, out int[] poly)
        {
            if (s.Length == 0)
                throw new FormatException("Последовательность не содержит элементов");
            bool flag = false;
            foreach (char c in s)
                if (Char.IsLetter(c))
                {
                    x = c;
                    flag = true;
                    break;
                }
            string[] monoms;
            if (flag)
            {
                s = s.Replace(" ", String.Empty);
                s = s.Replace("*", String.Empty);
                s = s.Replace("×", String.Empty);
                s = s.Replace("⋅", String.Empty);
                foreach (char c in s)
                    if (Char.IsLetter(c) && c != x)
                        throw new FormatException("Невозможно использование нескольких переменных");

                poly = new int[maxDeg(s) + 1];

                int num = 0;
                int deg = 0;
                int rank = 1;
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (Char.IsDigit(s[i]))
                    {
                        //num += (int)Char.GetNumericValue(s[i]) * rank;
                        num += (s[i] - '0') * rank;
                        rank *= 10;
                    }
                    else if (s[i] == x && num == 0)
                    {
                        if (i == s.Length - 1 || s[i + 1] != '^')
                            deg = 1;
                        rank = 1;
                    }
                    else if (s[i] == '^' && num != 0)
                    {
                        deg = Convert.ToInt32(num);
                        num = 0;
                        rank = 1;
                    }
                    else if (s[i] == '+' || s[i] == '-')
                    {
                        if (num != 0)
                            poly[deg] += Convert.ToInt32(s[i].ToString() + num.ToString());
                        else
                            poly[deg] += s[i] == '-' ? -1 : 1;
                        num = 0;
                        deg = 0;
                        rank = 1;
                    }
                    else
                        throw new FormatException("Невозможно распознать многочлен!");
                }
                poly[deg] += num;
                if (s[0] == x)
                    poly[deg] += 1;
            }
            else
            {
                monoms = s.Split(new char[] { ' ', '\n', '\t', '+' }, StringSplitOptions.RemoveEmptyEntries);
                poly = new int[monoms.Length];
                for (int i = poly.Length - 1; i >= 0; i--)
                    poly[i] = Convert.ToInt32(monoms[poly.Length - 1 - i]);
            }
            clipp(ref poly);
            if (isEmpty(poly))
                throw new FormatException("Многочлен не должен быть нулевым");
        }

        ///<summary>
        ///Отображает многочлен
        ///</summary>
        ///<param name="poly">Многочлен</param>
        ///<param name="shew">Переменная способа показа. Может принимать значения 1 (только коеффициенты) или 2 (полный вывод)</param>
        ///<param name="zpt">Количество знаков после запятой</param>
        string ShowPoly(double[] poly, int shew, int zpt)
        {
            string s = String.Empty;
            if (shew == 1)
            {
                for (int i = poly.Length - 1; i >= 0; i--)
                    s += Math.Round(poly[i], zpt) + " ";
            }
            else if (shew == 2)
            {
                double mon;
                for (int i = poly.Length - 1; i >= 0; i--)
                {
                    if (poly[i] != 0)
                    {
                        if (s == String.Empty)
                            s += poly[i] < 0 ? "- " : String.Empty;
                        else
                            s += poly[i] < 0 ? " - " : " + ";
                        mon = Math.Abs(poly[i]);
                        if (i == 0)
                            s += Math.Round(mon, zpt).ToString();
                        else if (i == 1)
                            s += (mon == 1 ? String.Empty : Math.Round(mon, zpt).ToString()) + x.ToString();
                        else
                            s += (mon == 1 ? String.Empty : Math.Round(mon, zpt).ToString()) + x.ToString() + "^" + i.ToString();
                    }
                }
            }
            else throw new FormatException("Неверный вызов функции ShowPoly");
            return s;
        }

        string ShowPoly(int[] poly, int shew)
        {
            string s = String.Empty;
            if (shew == 1)
            {
                for (int i = poly.Length - 1; i >= 0; i--)
                    s += poly[i] + " ";
            }
            else if (shew == 2)
            {
                int mon;
                for (int i = poly.Length - 1; i >= 0; i--)
                {
                    if (poly[i] != 0)
                    {
                        if (s == String.Empty)
                            s += poly[i] < 0 ? "- " : String.Empty;
                        else
                            s += poly[i] < 0 ? " - " : " + ";
                        mon = Math.Abs(poly[i]);
                        if (i == 0)
                            s += mon.ToString();
                        else if (i == 1)
                            s += (mon == 1 ? "" : mon.ToString()) + x.ToString();
                        else
                            s += (mon == 1 ? "" : mon.ToString()) + x.ToString() + "^" + i.ToString();
                    }
                }
            }
            else throw new FormatException("Неверный вызов функции ShowPoly");
            return s;
        }

        string Reverse(string str)
        {
            string strReverse = String.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
                strReverse += str[i];
            return strReverse;
        }

        private int maxDeg(string s)
        {
            string deg = String.Empty;
            int maxdeg = 1;
            bool degrun = false;
            for (int i = 0; i < s.Length; i++)
                if (s[i] == '^' && deg == String.Empty && !degrun)
                    degrun = true;
                else if (Char.IsDigit(s[i]) && degrun)
                    deg += s[i];
                else if (degrun && deg != String.Empty)
                {
                    if (Convert.ToInt32(deg) > maxdeg)
                        maxdeg = Convert.ToInt32(deg);
                    deg = String.Empty;
                    degrun = false;
                }
            if (degrun && deg != String.Empty)
            {
                if (Convert.ToInt32(deg) > maxdeg)
                    maxdeg = Convert.ToInt32(deg);
            }
            return maxdeg;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //FindPrimesAtkin((int)e.Argument, out bool[] prime);
            //e.Result = prime;
            int num = (int)e.Argument;
            for (int i = 2; i <= num; i++)
            {
                if (IsPrimeNum(i))
                    Invoke(new Action(() => listBox1.Items.Add(i)));
                backgroundWorker1.ReportProgress(i);
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
                
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Invoke(new Action(() => progressBar1.Visible = false));
            Invoke(new Action(() => btnCalc.Text = "Рассчитать"));
            Invoke(new Action(() => textBox5.ReadOnly = false));
        }
    }
}