// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The main program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Log4NetSample
{
    using System.Reflection;
    using log4net;

    /// <summary>
    /// The main program.
    /// </summary>
    // ReSharper disable once UnusedMember.Global
    public static class Program
    {
        /// <summary>
        /// The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod()?.DeclaringType);
        
        /// <summary>
        /// The main program.
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public static void Main()
        {
            Logger.Info("Application is working.");
            Logger.Error("New error.");
        }
    }
}