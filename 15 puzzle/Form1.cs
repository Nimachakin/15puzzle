using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _15_puzzle
{
    public partial class FifteenPuzzle : Form
    {
        #region Поля класса FifteenPuzzle
        int hh, mm, ss;
        const string START = "Start";
        const string NEWGAME = "New game";
        const string TIME = "{0}:{1}:{2}";
        PictureBox[] picboxes;
        Random random;
        Timer timer;
        #endregion
        #region Свойства полей класса FifteenPuzzle
        public int HH
        {
            get { return hh; }
            private set { hh = value; }
        }
        public int MM
        {
            get { return mm; }
            private set { mm = value; }
        }
        public int SS
        {
            get { return ss; }
            private set { ss = value; }
        }
        #endregion
        #region Конструктор класса FifteenPuzzle
        public FifteenPuzzle()
        {
            InitializeComponent();
            random = new Random();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(this.timeCounter_Tick);
            picboxes = new PictureBox[16] {one_picbox, two_picbox, three_picbox,
                                           four_picbox, five_picbox, six_picbox,
                                           seven_picbox, eight_picbox, nine_picbox, 
                                           ten_picbox, eleven_picbox, twelve_picbox,
                                           thirteen_picbox, fourteen_picbox, 
                                           fifteen_picbox, empty_picbox};
            newGame();
        }
        #endregion
        #region Методы проверки "правильного ряда"
        bool isFirstRowRight()
        {
            bool flag = false;
            if (one_picbox.Location.Y == two_picbox.Location.Y &&
                one_picbox.Location.Y == three_picbox.Location.Y &&
                one_picbox.Location.Y == four_picbox.Location.Y &&
                one_picbox.Location.Y < five_picbox.Location.Y)
                if (one_picbox.Location.X < two_picbox.Location.X &&
                   two_picbox.Location.X < three_picbox.Location.X &&
                   three_picbox.Location.X < four_picbox.Location.X)
                    flag = true;
            return flag;
        }
        bool isSecondRowRight()
        {
            bool flag = false;
            if (five_picbox.Location.Y == six_picbox.Location.Y &&
                five_picbox.Location.Y == seven_picbox.Location.Y &&
                five_picbox.Location.Y == eight_picbox.Location.Y &&
                five_picbox.Location.Y < nine_picbox.Location.Y)
                if (five_picbox.Location.X < six_picbox.Location.X &&
                   six_picbox.Location.X < seven_picbox.Location.X &&
                   seven_picbox.Location.X < eight_picbox.Location.X)
                    flag = true;
            return flag;
        }
        bool isThirdRowRight()
        {
            bool flag = false;
            if (nine_picbox.Location.Y == ten_picbox.Location.Y &&
                nine_picbox.Location.Y == eleven_picbox.Location.Y &&
                nine_picbox.Location.Y == twelve_picbox.Location.Y &&
                nine_picbox.Location.Y < thirteen_picbox.Location.Y)
                if (nine_picbox.Location.X < ten_picbox.Location.X &&
                   ten_picbox.Location.X < eleven_picbox.Location.X &&
                   eleven_picbox.Location.X < twelve_picbox.Location.X)
                    flag = true;
            return flag;
        }
        bool isFourthRowRight()
        {
            bool flag = false;
            if (thirteen_picbox.Location.Y == fourteen_picbox.Location.Y &&
                thirteen_picbox.Location.Y == fifteen_picbox.Location.Y)
                if (thirteen_picbox.Location.X < fourteen_picbox.Location.X &&
                   fourteen_picbox.Location.X < fifteen_picbox.Location.X)
                    flag = true;
            return flag;
        }
        #endregion
        #region Метод, объявляющий начало новой игры
        /// <Новая игра>
        /// Нажатие кнопки с текстом "New game"
        /// вызывает несколько методов: перетасовка пятнашек
        /// в массиве PictureBox[], распределение пятнашек
        /// по игровому полю, остановка таймера игры.
        /// Текст кнопки меняется на "Start".
        /// Игровая панель становится недоступна.
        /// </Новая игра>
        void newGame()
        {
            newGame_btn.Text = START;
            shuffleTheBlocks(picboxes);
            blockAllocation(picboxes);
            numPanel.Enabled = false;
            HH = MM = SS = 0;
            clock_lbl.Text = string.Format(TIME, HH, MM, SS);
            timer.Stop();
        }
        #endregion
        #region Метод, запускающий новую игру
        /// <Игровой процесс>
        /// При нажатии кнопки с текстом "Start",
        /// её текст меняется на "New Game".
        /// Запускается таймер игры.
        /// Игровая панель становится доступна.
        /// </Игровой процесс>
        void startGame()
        {
            newGame_btn.Text = NEWGAME;
            numPanel.Enabled = true;
            clock_lbl.Text = string.Format(TIME, HH, MM, SS);            
            timer.Start();
        }
        #endregion
        #region Методы, определяемые текстом кнопки игры
        void newGame_btn_Click(object sender, EventArgs e)
        {
            if (newGame_btn.Text == START)
                startGame();
            else
                newGame();
        }
        #endregion
        #region Метод, определяющий, что игрок победил
        /// <Победитель>
        /// Метод проверяет, чтобы все
        /// ряды игровой панели были заполнены
        /// правильно. Если это так, тогда таймер
        /// игры останавливается, и появляется текстовое
        /// сообщение с объявлением победы и временем,
        /// затраченным на текущую игру.
        /// Затем вызывается метод newGame().
        /// </Победитель>
        void isWinner()
        {
            if (isFirstRowRight() &&
               isSecondRowRight() &&
               isThirdRowRight() &&
               isFourthRowRight())
            {
                timer.Stop();
                MessageBox.Show("You won!\nTime elapsed\n" + clock_lbl.Text, "Winner!");
                newGame();                
            }
        }
        #endregion
        #region Перетаскивание пятнашек
        /// <summary>
        /// Метод принимает два параметра типа PictureBox.
        /// Координаты этих параметров сравниваются. Если оба
        /// параметра по отношению друг к другу расположены
        /// не по диагонали, тогда они обмениваются значениями
        /// своих координат.
        /// </summary>
        /// <param name="pb1"></param>
        /// <param name="pb2"></param>
        void switchTheBlocks(PictureBox pb1, PictureBox pb2)
        {
            PictureBox temp = new PictureBox();
            if ((Math.Abs(pb1.Location.X - pb2.Location.X) == 56 &&
                Math.Abs(pb1.Location.Y - pb2.Location.Y) == 0) ||
                (Math.Abs(pb1.Location.X - pb2.Location.X) == 0 &&
                Math.Abs(pb1.Location.Y - pb2.Location.Y) == 56))
            {
                temp.Location = pb1.Location;
                pb1.Location = pb2.Location;
                pb2.Location = temp.Location;
            }
        }
        #endregion
        #region Метод тасования пятнашек в массиве PictureBox[]
        // Используется алгоритм Фишера-Йетса
        // для случайного распределения "пятнашек"
        void shuffleTheBlocks(PictureBox[] pb)
        {
            int i = pb.Length;
            while (i > 1)
            {
                int j = random.Next(i--);
                PictureBox temp = pb[i];
                pb[i] = pb[j];
                pb[j] = temp;
            }
        }
        #endregion
        #region Распределение пятнашек в пределах игровой панели
        /// <Распределение>
        /// Начальные координаты расположения для левой пятнашки
        /// в верхнем ряду известно и задано заранее.
        /// За два цикла for в совокупности происходит 16 итераций,
        /// распределяющих 16 элементов массива PictureBox[].
        /// Сперва увеличивается координата "х" до тех пор, пока
        /// не будет заполнен верхний ряд панели, а затем
        /// значение "x" возвращается к первоначальному и
        /// увеличивается координата "y" для перехода на следующий
        /// ряд игровой панели.
        /// </Распределение>
        /// <param name="picBox"></param>
        void blockAllocation(PictureBox[] picBox)
        {
            int x = 3;
            int y = 3;
            int n = picBox.Length;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    picBox[--n].Location = new Point(x, y);
                    x += 56;
                }
                x = 3;
                y += 56;
            }
        }
        #endregion
        #region Метод, вызываемый при возникновении события timer.Tick
        /// <Время игры>
        /// В конструкторе класса FifteenPuzzle
        /// интервал возникновения события Tick поля timer
        /// устанавливается в 1000 миллисекунд или 1 секунда.
        /// Таким образом, каждую секунду значение
        /// поля FifteenPuzzle.SS увеличивается на 1,
        /// имитируя секундомер, отображаемый текстом
        /// метки clock_lbl.
        /// </Время игры>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void timeCounter_Tick(object sender, EventArgs e)
        {
            SS++;
            if (SS > 59)
            {
                SS = 0;
                MM++;
                if (MM > 59)
                {
                    MM = 0;
                    HH++;
                }
            }
            clock_lbl.Text = string.Format(TIME, HH, MM, SS);
        }
        #endregion
        #region События, вызывающие метод switchTheBlock() при нажатии на "пятнашку"
        /// <Проверка условия победы>
        /// В события, вызванные нажатием на пятнашки со значениями
        /// 12 и 15 (каждое является крайним правым для своего ряда),
        /// добавлена проверка "правильного расположения всех пятнашек"
        /// с помощью метода isWinner()
        /// </Проверка условия победы>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void one_picbox_Click(object sender, EventArgs e)
        {
            switchTheBlocks(one_picbox, empty_picbox);
        }
        void two_picbox_Click(object sender, EventArgs e)
        {
            switchTheBlocks(two_picbox, empty_picbox);
        }
        void three_picbox_Click(object sender, EventArgs e)
        {
            switchTheBlocks(three_picbox, empty_picbox);
        }
        void four_picbox_Click(object sender, EventArgs e)
        {
            switchTheBlocks(four_picbox, empty_picbox);
        }
        void five_picbox_Click(object sender, EventArgs e)
        {
            switchTheBlocks(five_picbox, empty_picbox);
        }
        void six_picbox_Click(object sender, EventArgs e)
        {
            switchTheBlocks(six_picbox, empty_picbox);
        }
        void seven_picbox_Click(object sender, EventArgs e)
        {
            switchTheBlocks(seven_picbox, empty_picbox);
        }
        void eight_picbox_Click(object sender, EventArgs e)
        {
            switchTheBlocks(eight_picbox, empty_picbox);
        }
        void nine_picbox_Click(object sender, EventArgs e)
        {
            switchTheBlocks(nine_picbox, empty_picbox);
        }
        void ten_picbox_Click(object sender, EventArgs e)
        {
            switchTheBlocks(ten_picbox, empty_picbox);
        }
        void eleven_picbox_Click(object sender, EventArgs e)
        {
            switchTheBlocks(eleven_picbox, empty_picbox);
        }
        void twelve_picbox_Click(object sender, EventArgs e)
        {
            switchTheBlocks(twelve_picbox, empty_picbox);
            if (empty_picbox.Location.X == 171 &&
               empty_picbox.Location.Y == 171)
                isWinner();
        }
        void thirteen_picbox_Click(object sender, EventArgs e)
        {
            switchTheBlocks(thirteen_picbox, empty_picbox);
        }
        void fourteen_picbox_Click(object sender, EventArgs e)
        {
            switchTheBlocks(fourteen_picbox, empty_picbox);
        }
        void fifteen_picbox_Click(object sender, EventArgs e)
        {
            switchTheBlocks(fifteen_picbox, empty_picbox);
            if (empty_picbox.Location.X == 171 &&
               empty_picbox.Location.Y == 171)
                isWinner();
        }
        #endregion

    }
}
