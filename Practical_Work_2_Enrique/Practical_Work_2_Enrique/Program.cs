namespace Practical_Work_2_Enrique
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            States state = new States();

            while(state.GetStates() != 0)
            {
                switch(state.GetStates())
                {
                    case 1: // from login - 1 
                        Application.Run(new Form1(state));
                        break;
                    case 2: // from regisster - 2
                        Application.Run(new RegisterAcc(state));
                        break;
                    case 3: // from Recuperar passwd - 3
                        Application.Run(new RecuperarPassword(state));
                        break;
                    case 4: // from calculator - 4
                        Application.Run(new Calculator(state));
                        break;
                }
            }
        }
    }
}