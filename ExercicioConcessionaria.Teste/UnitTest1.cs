using Xunit;
using System;
using ExercicioConcessionaria.Models;

namespace Unittest1;

public class Pessoa
{
    [Fact]
    public void CompradorDeUmVeiculoComEscolhaDeNaoTransmissao()
    {
        var carro = new Carro("Onix", "Chevrolet", DateTime.Now, 10, "Branco", 50.000, false, "Alcool");
        carro.SetTransmissaoAutomatica(false);
        Assert.Equal(false, carro.GetTransmissaoAutomatica());
    }

    [Fact]
    public void CompradorDeUmVeiculoComEscolhaDeComTransmissao()
    {
        var carro = new Carro("EcoSport", "Ford" ,DateTime.Now, 1000, "Branca", 80.000, true, "Alcool");
        carro.SetTransmissaoAutomatica(true);
        Assert.Equal(true, carro.GetTransmissaoAutomatica());
    }
    [Fact]
    public void CompradorDeMotoEscolheCilindrada()
    {
        var moto = new Moto("Yamaha", "R1", DateTime.Now, 0000, "azul", 160.000, 1000, "Eletrica" );
        moto.SetCilindrada(1000);
        Assert.Equal(1000, moto.GetCilindrada());
    }
    [Fact]
    public void CompradorDeMotoEscolheModeloDePartidaEletricaOuPedal()
    {
        var moto = new Moto("Yamaha", "R1", DateTime.Now, 0000, "azul", 160.000, 1000, "Eletrica");
        moto.SetPartida("Eletrica");
        Assert.Equal("Eletrica", moto.GetPartida());
    }
    [Fact]
    public void ClienteCadastraEmail()
    {
        var cliente = new Cliente("Leandro", "11122233345", DateTime.Now, "leandroDodev@gmail.com", "(11)20615474");
        cliente.SetEmail("leandroDodev@gmail.com");
        Assert.Equal("leandroDodev@gmail.com", cliente.GetEmail());
    }
    [Fact]
    public void ClienteCadastraTelefoneParaContato()
    {
        var cliente = new Cliente("Leandro", "11122233345", DateTime.Now, "leandroDodev@gmail.com", "(11)20615474");
        cliente.SetTelefone("(11)20615474");
        Assert.Equal("(11)20615474", cliente.GetTelefone());
    }
    [Fact]
    public void FichaCadastralCompletoFuncionario()
    {
        var funcionario = new Funcionario("Darlan", "11122233344", DateTime.Now, "Gerente.DEV");
        funcionario.SetCargo("Gerente.DEV");
        Assert.Equal("Gerente.DEV", funcionario.GetCargo());
    }
    [Fact]
    public void PessoaPreencheCamposParaFichaCadastralComNome()
    {
        var pessoa = new Pessoa("Leandro", "Cpf", DateTime.Now );
        pessoa.SetNome("Leandro");
        Assert.Equal("Leandro", GetNome());
    }
    [Fact]
    public void PessoaPreencheCamposParaFichaCadastralComCpf()
    {
        var pessoa = new Pessoa("Leandro", "11122233345", DateTime.Now );
        pessoa.SetCpf("11122233345");
        Assert.Equal("11122233345", GetCpf());
    }
  
    





   
}