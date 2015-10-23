﻿using System;
using JetBrains.Annotations;
using MGR.CommandLineParser.Command;

namespace MGR.CommandLineParser
{
    /// <summary>
    ///     Defines the contract for the activator of <see cref="ICommand" />.
    /// </summary>
    public interface ICommandActivator
    {
        /// <summary>
        ///     Activates (create an instance) of a <see cref="ICommand" />.
        /// </summary>
        /// <param name="commandType">The type of the command.</param>
        /// <returns>The command.</returns>
        ICommand ActivateCommand([NotNull] Type commandType);
    }
}