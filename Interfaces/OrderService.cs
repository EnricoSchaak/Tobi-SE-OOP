namespace Interfaces;

public class OrderService
{
    private BaseLogger _logger;

    
    public OrderService(BaseLogger logger)
    {
        _logger = logger;
    }

    public void ProcessOrder(string orderID)
    {
    /* Hier den Logger zu instanziieren macht diese Klasse abhängig von der spezifischen Logger-Implementation.
    Wenn die Logger-Implementation ausgetauscht werden soll, kann dies zu viel
    Arbeit führen, je nach größe der Klasse. */
    /* var logger = new Logger(); !Abhängigkeit! */
 
        _logger.Log($"Order {orderID} is being processed");
        Thread.Sleep(1000);
        _logger.Log($"Order {orderID} processed succesfully");
        Thread.Sleep(1000);
        _logger.Log($"Order {orderID} processing complete");
        Thread.Sleep(1000);
    }
}
