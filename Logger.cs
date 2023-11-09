namespace EstudoCRUDAPI
{
    public static class Logger
    {
        private static readonly string logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");

        static Logger()
        {
            string logDirectory = Path.GetDirectoryName(logFilePath);

            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }
        }

        public static void LogMessage(string message)
        {
            Log($"{DateTime.Now} - {message}");
        }

        public static void LogException(Exception ex)
        {
            Log($"Erro: {ex.Message}");
        }

        private static void Log(string message)
        {
            try
            {
               using (StreamWriter write = File.AppendText(logFilePath))
                {
                    write.WriteLine(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao escrever no arquivo de log:: {ex.Message}");
            }

        }
    }
}
