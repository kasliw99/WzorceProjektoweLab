namespace CodeSmells
{
    internal class DuplicatedCode
    {

        public void LogError(string message, DateTime timestamp)
        {
            //string formattedTimestamp = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
            //string formattedMessage = $"ERROR: [{formattedTimestamp}] {message}";
            string formattedMessage = FormatLogMessage("ERROR", message, timestamp);
            Console.WriteLine(formattedMessage);
        }

        public void LogWarning(string message, DateTime timestamp)
        {
            //string formattedTimestamp = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
            //string formattedMessage = $"WARNING: [{formattedTimestamp}] {message}";
            string formattedMessage = FormatLogMessage("WARNING", message, timestamp);
            Console.WriteLine(formattedMessage);
        }

        private string FormatLogMessage(string logType, string message, DateTime timestamp)
        {
            string formattedTimestamp = timestamp.ToString("yyyy-MM-dd HH:mm:ss");
            return $"{logType}: [{formattedTimestamp}] {message}";
        }
        
    }
}
