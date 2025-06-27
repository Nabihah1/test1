using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1_Porg_part_3
{
    public partial class Form1: Form
    {

        Dictionary<string, string> responses = new Dictionary<string, string>
        {
            { "how are you", "I'm doing great! How can I assist you with cybersecurity today?" },
            { "what's your purpose", "My purpose is to educate you on how to create a safe environment online by giving cybersecurity tips." +
                  "\nI can answer questions regarding phishing emails, password safety and safe browsing."},
            { "help", "You can ask about passwords, phishing, safe browsing, or general cybersecurity guidance." }
        };
        Dictionary<string, List<string>> keywordGroups = new Dictionary<string, List<string>>()
        {
            {"password", new List<string> {"passwords", "password", "strong password", "secure password"} },
            {"phishing", new List<string> {"phishing", "phishing email", "fake email", "scam", "scams"} },
            {"safe browsing", new List<string> {"browse safely", "secure browsing", "browsing","privacy", "safe-browsing"} },
             {"how are you", new List <string> {"how are u", "how r u", "how are you?", "how r u?"} },
                {"what's your purpose", new List <string> {"purpose", "what is your purpose", "whats your purpose" } },
        };

        //dictionary to store a phrases of confused words 
        public static string lastTopic = " ";
        static List<string> confusedWords = new List<string>
        {
            "i do not understand", "what", "explain", "dont understand", "don't understand", "huh", "confused", "lost", "more detail", "more info", "more information", "explain in more detail"
        };



        public Form1()
        {
            InitializeComponent();
        }
    }
}
