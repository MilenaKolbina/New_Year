using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace новый_год
{
    public partial class Game : Form
    {
        static string[] words;
        static string current_word;
        static string show_text;
        static int count_success;
        static int count_spaces;
        static int lives;
        static PictureBox[] lives_picture;
        public Game()
        {
            InitializeComponent();
            lives_picture = new PictureBox[] { pictureBox5, pictureBox4, pictureBox3, pictureBox2, pictureBox7, pictureBox6 };
            words = new string[] { "карнавал", "праздник", "дед мороз", "сюрприз", "ёлочка" };
            current_word = "";
            show_text = "";
            count_success = 0;
            count_spaces = 0;
            lives = lives_picture.Length;

            start_game(richTextBox1, lives_picture);
        }

        public static void start_game(RichTextBox wordArea)
        {
            Random random = new Random();
            int i = random.Next(0, words.Length);
            current_word = words[i];
            show_text = get_show_text(current_word);
            wordArea.Text = show_text;
            centering_text(wordArea);
            count_success = 0;
            lives = lives_picture.Length;

        }

        public static void start_game(RichTextBox wordArea, PictureBox[] pictureBox)
        {
            start_game(wordArea);
            Bitmap bmp = new Bitmap(Properties.Resources.подарок);
            for (int i = 0; i < pictureBox.Length; i++)
            {
                pictureBox[i].SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox[i].Image = bmp;
            }
        }

        public static void centering_text(RichTextBox word_area)
        {
            word_area.SelectAll();
            word_area.SelectionAlignment = HorizontalAlignment.Center;
        }

        public static bool is_contains(string word, char symbol)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol)
                {
                    return true;
                }
            }
            return false;
        }

        public static string get_new_show_text(string word, char symbol, string old_show_text)
        {
            string result = "";
            for (int i = 0; i < old_show_text.Length; i += 2)
            {
                if (word[i / 2] == symbol)
                {
                    result += symbol + " ";
                    count_success++;
                }
                else
                {
                    result += old_show_text[i] + " ";
                }
            }
            return result;
        }

        public static string get_show_text(string word)
        {
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    result += "  ";
                    count_spaces++;
                }
                else
                {
                    result += "* ";
                }
            }
            return result;
        }

        public static void button_symbol_click(RichTextBox wordArea, char symbol, Button cur_button, Button startButton)
        {
            bool is_const = is_contains(current_word, symbol);
            if (is_const)
            {
                show_text = get_new_show_text(current_word, symbol, show_text);
                wordArea.Text = show_text;
                centering_text(wordArea);
            }
            else
            {
                lives--;
                lives_picture[lives].Image = null;
            }
            cur_button.Enabled = false;
            if (lives == 0)
            {
                using (Loss If = new Loss())
                {
                    If.ShowDialog();
                }
            }
            else if ((count_success + count_spaces) == current_word.Length)
            {
                using (Success sf = new Success())
                {
                    sf.ShowDialog();
                }
            }
        }
        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void Button19_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'в', button19, button2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'а', button3, button2);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'б', button8, button2);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'г', button20, button2);
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'д', button23, button2);
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'и', button22, button2);
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'е', button28, button2);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ё', button7, button2);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ж', button15, button2);
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'з', button21, button2);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'м', button6, button2);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'н', button18, button2);
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'о', button26, button2);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'л', button14, button2);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'к', button5, button2);
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'й', button27, button2);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'п', button4, button2);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'р', button11, button2);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'с', button16, button2);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'т', button17, button2);
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'у', button25, button2);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ф', button9, button2);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'х', button10, button2);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ц', button12, button2);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ч', button13, button2);
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ш', button24, button2);
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'щ', button29, button2);
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ъ', button30, button2);
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ы', button31, button2);
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ь', button32, button2);
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'э', button35, button2);
        }

        private void Button34_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ю', button34, button2);
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'я', button33, button2);
        }
    }
}