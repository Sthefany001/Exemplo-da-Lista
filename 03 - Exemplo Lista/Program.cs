using _03___Exemplo_Lista;

Aluno aluno1 = new Aluno();
aluno1.Nome = "Elias";
aluno1.Cpf = "222";

Aluno aluno2 = new Aluno(11, "Maria", "05364291174", new DateOnly(1995, 07, 23));

List<Aluno> alunos = new List<Aluno>();
alunos.Add(aluno1);
alunos.Add(aluno2);

foreach(Aluno a in alunos)
{
    Console.WriteLine($"O nome é {a.Nome} {a.Cpf}");
}
