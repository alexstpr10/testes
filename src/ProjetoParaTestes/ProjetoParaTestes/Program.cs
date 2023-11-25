// See https://aka.ms/new-console-template for more information
using ProjetoParaTestes.Services;

Console.WriteLine("Hello, World!");

CalculoGarantia calculoGarantia = new CalculoGarantia();

Console.WriteLine("Inicio Calculo Parte 1");
Console.WriteLine($"Margem calculadada parte igual: {calculoGarantia.CalcularMargemParte(-10000000, 4310000, 5000000, 600000, 300000)}");
Console.WriteLine("\nInicio Calculo Parte 2");
Console.WriteLine($"Margem calculadada parte igual: {calculoGarantia.CalcularMargemParte(-4000000, 4410000, 5000000, 500000, 300000)}");
Console.WriteLine("\nInicio Calculo Contra Parte 1");
Console.WriteLine($"Margem calculadada contraparte igual: {calculoGarantia.CalcularMargemContraParte(6000000, 0, 5000000, 500000, 300000)}");
Console.WriteLine("\nInicio Calculo Contra Parte 2");
Console.WriteLine($"Margem calculadada contraparte igual: {calculoGarantia.CalcularMargemContraParte(6000000, -400000, 5000000, 700000, 300000)}");
Console.WriteLine("\nInicio Calculo Contra Parte 3");
Console.WriteLine($"Margem calculadada contraparte igual: {calculoGarantia.CalcularMargemContraParte(6000000, -2000000, 5000000, 700000, 300000)}");
Console.WriteLine("\nInicio Calculo Contra Parte 4");
Console.WriteLine($"Margem calculadada contraparte igual: {calculoGarantia.CalcularMargemContraParte(6000000, -1400000, 5000000, 700000, 300000)}");
Console.WriteLine("\nInicio Calculo Contra Parte 5");
Console.WriteLine($"Margem calculadada contraparte igual: {calculoGarantia.CalcularMargemContraParte(3000000, -3100000, 5000000, 500000, 3000000)}");