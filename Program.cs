﻿internal class Program
{
    private static void Main(string[] args)
    {
        string yourName = Environment.GetEnvironmentVariable("YOUR_NAME").ToString();
        string timeExperience = Environment.GetEnvironmentVariable("TIME_EXPERINCE").ToString();
        string rule = Environment.GetEnvironmentVariable("RULE").ToString();
        string skills = Environment.GetEnvironmentVariable("SKILLS").ToString();


        string recrutador = args[0];
        string empresa = args[1];

        string msg = $"Olá {recrutador},\n\nEncontrei seu perfil no LinkedIn e gostaria de me conectar com você para possiveis oportunidades. Estou buscando novas oportunidades na área de {rule} e adoraria conectar-me para aprender mais sobre as oportunidades na {empresa}.\n\nTenho {timeExperience} de experiência em desenvolvimento de software e acredito que minhas habilidades em {skills} podem ser um bom complemento para a equipe da {empresa}.\n\nAgradeço pelo seu tempo e espero que possamos nos conectar.\n\nAtenciosamente,\n{yourName}";     
    
        Console.WriteLine(msg);
    }
}