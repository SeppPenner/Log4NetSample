// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The main program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Log4NetSample;

/// <summary>
/// The main program.
/// </summary>
public static class Program
{
    /// <summary>
    /// The logger.
    /// </summary>
    private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod()?.DeclaringType ?? typeof(Program));

    /// <summary>
    /// The main program.
    /// </summary>
    public static void Main()
    {
        Logger.Info("Application is working.");
        Logger.Error("New error.");
    }
}
