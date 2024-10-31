public class veiculoDAO
{
    public List<Veiculo>ListaVeiculos = new List<Veiculo> ();

    public void cadastrar(Veiculo v)
    {
        ListaVeiculos.Add(v);
    }

    public List<Veiculo> ListarTodos()
    {
        return ListaVeiculos;
    }
    public void remover(string placa)
    {
        Veiculo vExcluir = ListaVeiculos.First(p=> p.placa == placa );
        ListaVeiculos.Remove(vExcluir);
    }
    public Veiculo BuscarPlaca(string placa)
    {
        Veiculo veiculo = ListaVeiculos.First(p => p.placa == placa);
        return veiculo;
    }
   
}