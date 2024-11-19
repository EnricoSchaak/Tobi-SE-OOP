/*
var orderService = new OrderService();
oderService.ProcessOrder("122345");
*/
using Interfaces;

var consoleLogger = new ConsoleLogger();

var orderService = new OrderService(consoleLogger);
orderService.ProcessOrder("123456");
orderService.ProcessOrder("789101");


var filelogger = new FileLogger();
var orderServiceWithFileLogging = new OrderService(filelogger);
orderServiceWithFileLogging.ProcessOrder("421024");
orderServiceWithFileLogging.ProcessOrder("133769");

/*
  var myBaseLogger = new BaseLogger();
  myBaseLogger.Log("buxtehude");
*/