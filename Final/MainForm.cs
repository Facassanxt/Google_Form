using System;
using Microsoft.Win32;
using System.ComponentModel;
using System.Runtime.InteropServices;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Final
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private int colorSchemeIndex;
        List<string> IdForm = new List<string>();
        List<List<string>> Form = new List<List<string>>();
        string FinalURL = "";
        object _lockAction = new object();
        bool _isCopleted = false;

        public MainForm()
        {
            SetBrowserFeatureControl();
            InitializeComponent();
            WB.ScriptErrorsSuppressed = true;

            this.Width = 1280;
            this.Height = 720;

            materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange300, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            colorSchemeIndex = 4;
            UpdateColor();


            Switch_Language.Checked = false;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
        private void UpdateColor()
        {
            //These are just example color schemes
            switch (colorSchemeIndex)
            {
                //ColorScheme(primary, darkPrimary, lightPrimary, accent, textShade)
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.DeepOrange300 : Primary.DeepOrange300,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.BlueGrey900 : Primary.DeepOrange900,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.BlueGrey500 : Primary.DeepOrange100,
                        Accent.LightBlue200,
                        TextShade.WHITE);
                    break;
                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Green600,
                        Primary.Green700,
                        Primary.Green200,
                        Accent.Red100,
                        TextShade.WHITE);
                    break;
                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal500 : Primary.Indigo500,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal700 : Primary.Indigo700,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal200 : Primary.Indigo100,
                        Accent.Pink200,
                        TextShade.WHITE);
                    break;
                case 3:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.DeepPurple700,
                        Primary.DeepPurple900,
                        Primary.DeepPurple500,
                        Accent.Green400,
                        TextShade.WHITE);
                    break;
                case 4:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.BlueGrey800,
                        Primary.BlueGrey900,
                        Primary.BlueGrey500,
                        Accent.LightBlue200,
                        TextShade.WHITE);
                    break;
            }
            Refresh();
        }

        private void Bu_Change_Colors_Click(object sender, EventArgs e)
        {
            colorSchemeIndex++;
            if (colorSchemeIndex > 4)
                colorSchemeIndex = 0;
            UpdateColor();
        }
        private void Switch_Use_menu_colors_CheckedChanged(object sender, EventArgs e)
        {
            DrawerUseColors = Switch_Use_menu_colors.Checked;
        }
        private void Switch_Highlight_with_Accent_CheckedChanged(object sender, EventArgs e)
        {
            DrawerHighlightWithAccent = Switch_Highlight_with_Accent.Checked;
        }
        private void Switch_Background_with_Accent_CheckedChanged(object sender, EventArgs e)
        {
            DrawerBackgroundWithAccent = Switch_Background_with_Accent.Checked;
        }
        private void Switch_Display_Icons_when_hidden_CheckedChanged(object sender, EventArgs e)
        {
            DrawerShowIconsWhenHidden = Switch_Display_Icons_when_hidden.Checked;
        }
        private void Switch_Language_CheckedChanged(object sender, EventArgs e)
        {
            if (Switch_Language.Checked == true)
            {
                Text = "Google Form by Facassanxt";
                /*                  Settings page                   */
                Label1.Text = "Application settings";
                Bu_Change_Colors.Text = "Change Colors";
                Switch_Change_Theme.Text = "Change Theme - LIGHT ⮀ DARK";
                Switch_Use_menu_colors.Text = "Drawer - Use menu colors";
                Switch_Highlight_with_Accent.Text = "Drawer - Highlight with Accent";
                Switch_Background_with_Accent.Text = "Drawer - Background with Accent";
                Switch_Display_Icons_when_hidden.Text = "Drawer - Display Icons when hidden";
                Switch_Language.Text = "Language - RU ⮀ ENG";
                //////////////////////////////////////////////////////

                /*                  Menu                    */
                tabPageMenuCiphers.Text = "Form";
                tabPageMenuSettings.Text = "Settings";
                //////////////////////////////////////////////
            }
            else
            {
                Text = "Google Form by Facassanxt";
                /*                  Страница настроек                   */
                Label1.Text = "Настройки приложения";
                Bu_Change_Colors.Text = "Изменить цвет";
                Switch_Change_Theme.Text = "Сменить тему - СВЕТЛАЯ ⮀ ТЕМНАЯ";
                Switch_Use_menu_colors.Text = "Отрисовка - Использовать цвета меню";
                Switch_Highlight_with_Accent.Text = "Отрисовка - Выделить с акцентом";
                Switch_Background_with_Accent.Text = "Отрисовка - Фон с акцентом";
                Switch_Display_Icons_when_hidden.Text = "Отрисовка - Отображать значки, когда они скрыты";
                Switch_Language.Text = "Язык - RU ⮀ ENG";
                //////////////////////////////////////////////////////////

                /*                  Меню                    */
                tabPageMenuCiphers.Text = "Форма";
                tabPageMenuSettings.Text = "Настройки";
                //////////////////////////////////////////////
            }
            Refresh();
        }
        private void Switch_Change_Theme_CheckedChanged(object sender, EventArgs e)
        {
            Visible = false;
            materialSkinManager.Theme = Switch_Change_Theme.Checked == true ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;
            UpdateColor();
            Visible = true;
        }

        private void SetBrowserFeatureControlKey(string feature, string appName, uint value)
        {
            using (var key = Registry.CurrentUser.CreateSubKey(
                String.Concat(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\", feature),
                RegistryKeyPermissionCheck.ReadWriteSubTree))
            {
                key.SetValue(appName, (UInt32)value, RegistryValueKind.DWord);
            }
        }

        private void SetBrowserFeatureControl()
        {
            var fileName = System.IO.Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName);
            if (String.Compare(fileName, "devenv.exe", true) == 0 || String.Compare(fileName, "XDesProc.exe", true) == 0)
                return;
            SetBrowserFeatureControlKey("FEATURE_BROWSER_EMULATION", fileName, GetBrowserEmulationMode()); // Webpages containing standards-based !DOCTYPE directives are displayed in IE10 Standards mode.
            SetBrowserFeatureControlKey("FEATURE_AJAX_CONNECTIONEVENTS", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_MANAGE_SCRIPT_CIRCULAR_REFS", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_DOMSTORAGE ", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_GPU_RENDERING ", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_IVIEWOBJECTDRAW_DMLT9_WITH_GDI  ", fileName, 0);
            SetBrowserFeatureControlKey("FEATURE_DISABLE_LEGACY_COMPRESSION", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_LOCALMACHINE_LOCKDOWN", fileName, 0);
            SetBrowserFeatureControlKey("FEATURE_BLOCK_LMZ_OBJECT", fileName, 0);
            SetBrowserFeatureControlKey("FEATURE_BLOCK_LMZ_SCRIPT", fileName, 0);
            SetBrowserFeatureControlKey("FEATURE_DISABLE_NAVIGATION_SOUNDS", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_SCRIPTURL_MITIGATION", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_SPELLCHECKING", fileName, 0);
            SetBrowserFeatureControlKey("FEATURE_STATUS_BAR_THROTTLING", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_TABBED_BROWSING", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_VALIDATE_NAVIGATE_URL", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_WEBOC_DOCUMENT_ZOOM", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_WEBOC_POPUPMANAGEMENT", fileName, 0);
            SetBrowserFeatureControlKey("FEATURE_WEBOC_MOVESIZECHILD", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_ADDON_MANAGEMENT", fileName, 0);
            SetBrowserFeatureControlKey("FEATURE_WEBSOCKET", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_WINDOW_RESTRICTIONS ", fileName, 0);
            SetBrowserFeatureControlKey("FEATURE_XMLHTTP", fileName, 1);
        }

        private UInt32 GetBrowserEmulationMode()
        {
            int browserVersion = 7;
            using (var ieKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer",
                RegistryKeyPermissionCheck.ReadSubTree,
                System.Security.AccessControl.RegistryRights.QueryValues))
                {
                    var version = ieKey.GetValue("svcVersion");
                    if (null == version)
                    {
                        version = ieKey.GetValue("Version");
                        if (null == version)
                            throw new ApplicationException("Microsoft Internet Explorer is required!");
                    }
                    int.TryParse(version.ToString().Split('.')[0], out browserVersion);
                }

            UInt32 mode = 11000; // Internet Explorer 11. Webpages containing standards-based !DOCTYPE directives are displayed in IE11 Standards mode. Default value for Internet Explorer 11.
            switch (browserVersion)
            {
                case 7:
                    mode = 7000; // Webpages containing standards-based !DOCTYPE directives are displayed in IE7 Standards mode. Default value for applications hosting the WebBrowser Control.
                    break;
                case 8:
                    mode = 8000; // Webpages containing standards-based !DOCTYPE directives are displayed in IE8 mode. Default value for Internet Explorer 8
                    break;
                case 9:
                    mode = 9000; // Internet Explorer 9. Webpages containing standards-based !DOCTYPE directives are displayed in IE9 mode. Default value for Internet Explorer 9.
                    break;
                case 10:
                    mode = 10000; // Internet Explorer 10. Webpages containing standards-based !DOCTYPE directives are displayed in IE10 mode. Default value for Internet Explorer 10.
                    break;
                default:
                    // use IE11 mode by default
                    break;
            }

            return mode;
        }
        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                WB.Navigate(new Uri(address));
            }
            catch (Exception)
            {
            }

        }

        private void URL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (URL != null)
                {
                    try
                    {
                        FinalURL = URL.Text;
                        Navigate(URL.Text);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IdForm.Clear();
                Form.Clear();
                HtmlElement res = null;
                int count = 0;
                foreach (HtmlElement el in WB.Document.GetElementsByTagName("div"))
                {
                    if (el.GetAttribute("className") == "freebirdFormviewerComponentsQuestionRadioChoicesContainer" || el.GetAttribute("className") == "freebirdFormviewerComponentsQuestionCheckboxRoot")
                    {
                        List<string> list = new List<string>();
                        foreach (HtmlElement te in el.GetElementsByTagName("span"))
                            if (te.GetAttribute("dir") == "auto")
                            {
                                if (te.InnerHtml != "Другое:")
                                {
                                    list.Add(te.InnerHtml.Replace(' ', '+'));
                                    Console.WriteLine(te.InnerHtml);
                                }
                            }
                        Console.WriteLine("==========================");
                        Form.Add(list);
                    }
                    if (el.GetAttribute("className") == "freebirdMaterialScalecontentContainer")
                    {
                        List<string> list = new List<string>();
                        foreach (HtmlElement te in el.GetElementsByTagName("div"))
                            if (te.GetAttribute("className") == "freebirdMaterialScalecontentLabel")
                            {
                                list.Add(te.InnerHtml.Replace(' ', '+'));
                                Console.WriteLine(te.InnerHtml);
                            }
                        Console.WriteLine("==========================");
                        Form.Add(list);
                    }
                    if (el.GetAttribute("className") == "quantumWizTextinputPaperinputInputArea")
                    {
                        List<string> list = new List<string>();
                        list.Add(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("==========================");
                        Form.Add(list);
                    }
                }
                foreach (HtmlElement el in WB.Document.GetElementsByTagName("script"))
                {
                    if (el.GetAttribute("type") == "text/javascript")
                    {
                        if (count == 1)
                        {
                            res = el;
                            break;
                        }
                        count++;
                    }
                }
                Regex regex = new Regex("[[]{2}[\\d]{5,}");
                MatchCollection matches = regex.Matches(res.InnerHtml);
                if (matches.Count > 0)
                    foreach (Match match in matches)
                        IdForm.Add(match.Value.Substring(2));
                IdForm.RemoveRange(0, 1);
                foreach (var item in IdForm)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Парсер окончен");

            }
            catch (Exception)
            {
            }
        }
        private string Random_All_Form(List<List<string>> form, List<string> idForm)
        {
            Random rnd = new Random();
            String temp = "https://docs.google.com/forms/d/e/1FAIpQLSentHkCp0AKal-I3Pbw9BSzCqI-kl6HFh1hfGEeGOdVQnxhAg/viewform" + "?usp=pp_url";
            for (int i = 0; i < form.Count; i++)
            {
                if (i == 0)
                {
                    temp += $"&entry.{idForm[i]}=Да,+слушаю";
                }
                else 
                {
                    int CountRandom = form[i].Count;
                    temp += $"&entry.{idForm[i]}={form[i][rnd.Next(CountRandom)]}";
                }
            }
            return temp;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string a = Random_All_Form(Form, IdForm);
            Navigate(a);
            Application.DoEvents();
            await Task.Delay(300);
            //lock (_lockAction)
            //{
            //    foreach (HtmlElement el in WB.Document.GetElementsByTagName("div"))
            //    {
            //        if (el.GetAttribute("role") == "button")
            //        {
            //            el.InvokeMember("Click");
            //            break;
            //        }
            //    }
            //    Refresh();
            //    _isCopleted = false;
            //    while (_isCopleted == false)
            //    {
            //        Application.DoEvents();
            //        _isCopleted = true;
            //    }
            //}
            //await Task.Delay(2000);
            lock (_lockAction)
            {
                foreach (HtmlElement el in WB.Document.GetElementsByTagName("span"))
                {
                    if (el.GetAttribute("className") == "appsMaterialWizButtonPaperbuttonLabel quantumWizButtonPaperbuttonLabel exportLabel")
                    {
                        if (el.InnerText == "Отправить")
                        {
                            el.InvokeMember("Click");
                            break;
                        }
                    }
                }
                Refresh();
                _isCopleted = false;
                while (_isCopleted == false)
                {
                    Application.DoEvents();
                    _isCopleted = true;
                }
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    Navigate(FinalURL);
                    Application.DoEvents();
                    Refresh();
                    button2.PerformClick();
                    Console.WriteLine($"#{i} отправлен");
                });
                await Task.Delay(7000);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}