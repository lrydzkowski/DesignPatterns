using CommandDotNet;
using CommandDotNet.IoC.MicrosoftDependencyInjection;
using DesignPatterns.CLI;
using Microsoft.Extensions.DependencyInjection;

ServiceProvider serviceProvider = new ServiceCollection().AddServices().BuildServiceProvider();

AppRunner appRunner = new AppRunner<Commands>();
appRunner.UseMicrosoftDependencyInjection(serviceProvider).Run(args);
