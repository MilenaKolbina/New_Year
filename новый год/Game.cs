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
            lives_picture = new PictureBox [] { pictureBox5, pictureBox4, pictureBox3, pictureBox2, pictureBox7, pictureBox6 };
            words = new string[] { "карнавал", "праздник", "дед мороз", "сюрприз", "ёлочка" };
            current_word = "";
            show_text = "";
            count_success = 0;
            count_spaces = 0;
            lives = lives_picture.Length;
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

        public static void start_game(RichTextBox wordArea,PictureBox pictureBox)
        {
            start_game(wordArea);
            PictureBox bmp = new Bitmap(Properties.Resources.);
            for (int i = 0; i < lives_picture.Length; i++)
            {
                lives_picture[i].SizeMode = PictureBoxSizeMode.Zoom;
                lives_picture[i].Image = bmp;
            }
        }

        public static void centering_text(RichTextBox word_area)
        {
            word_area.SelectAll();
            word_area.SelectionAlignment = HorizontalAlignment.Center;
        }

        public static bool is_contains (string word, char symbol)
        {

        }

        public static string get_new_show_text( string word, char symbol,string old_show_text)
        {

        }

        public static string get_show_text (string word)
        {
            

        }

        public static void button_symbol_click (RichTextBox wordArea, char symbol, Button cur_button, Button startButton)
        {

        }
        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void Button19_Click(object sender, EventArgs e)
        {

        }
    }
}
