internal class PlaceResourcesInStockpile : IState
{
    private readonly Gatherer _gatherer;

    public PlaceResourcesInStockpile(Gatherer gatherer)
    {
        _gatherer = gatherer;
    }

    public void Tick()
    {
        if (_gatherer.Take())
            _gatherer.StockPile.Add();
    }

    public void OnEnter() { }

    public void OnExit() { }
}