using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Game : Form
    {
        static string[] words;

        static string current_word;

        static string show_text;

        static int count_success;

        static int count_spaces;

        static int lives;

        static PictureBox[] lives_image;
        static void start_game(RichTextBox wordArea, PictureBox[] lives_image)

        {



        }

        static string get_show_text(string word)

        {

            string result_string = "";

            for (int i = 0; i < word.Length; i++)

            {

                result_string += "—";

            }

            return result_string;

        }

        static void centering_text(RichTextBox word_area)

        {



        }

        static bool is_contains(string word, char symbol)

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

        static string get_new_show_text(string word, char symbol, string old_show_text)

        {

            for (int i = 0; i < word.Length; i++)

            {

                if (word[i] == symbol)

                {

                    old_show_text = old_show_text.Remove(i, 1);

                    old_show_text = old_show_text.Insert(i, symbol.ToString());

                }

            }

            return old_show_text;

        }

        static void button_symbol_click(RichTextBox wordArea, Button cur_button, Button startButton)

        {

            char symbol = cur_button.Text[0];
            if (is_contain(current_word, symbol))

            {



            }

            else

            {



            }

        }

        public Game_field()

        {

            InitializeComponent();

            lives_image = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };

            words = new string[] { "лось", "карнавал", "ёлочка", "праздник", "дед мороз", "олень", "сюрприз", "зима", "снегурочка", "ёхансон", "снег", "сугроб" };

            current_word = "";

            show_text = "";

            count_success = 0;

            count_spaces = 0;

            lives = lives_image.Length;

            //pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;

        }



    }

}
