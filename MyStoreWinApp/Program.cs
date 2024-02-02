using DataAccess.Repository;

namespace MyStoreWinApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin formLogin = new()
            {
                MemberRepository = new MemberRepository()
            };
            Application.Run(formLogin);
        }
    }
}