// See https://aka.ms/new-console-template for more information
using System;
class DocumentWorker
    {
    public virtual void OpenDocument()
        {
        Console.WriteLine("Документ открыт");
        }
    public virtual void EditDocument()
        {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
        }
    public virtual void SaveDocument()
        {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
        }
}
class ProDocumentWorker : DocumentWorker
    {
    public override void EditDocument()
        {
        Console.WriteLine("Документ отредактирован");
        }
    public override void SaveDocument()
        {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
            }
}
class ExpertDocumentWorker : ProDocumentWorker
    {
    public override void SaveDocument()
        {
        Console.WriteLine("Документ сохранен в новом формате");
        }
    }
class Program
    {
    static void Main()
    {
        DocumentWorker documentWorker;
        Console.WriteLine("Введите номер ключа доступа (pro/expert): ");
        string key = Console.ReadLine();

        switch (key.ToLower())
            {
            case "112113":
                documentWorker = new ProDocumentWorker();
                break;
            case "112233":
                documentWorker = new ExpertDocumentWorker();
                break;
            default:
                documentWorker = new DocumentWorker();
                break;
            }

        documentWorker.OpenDocument();
        documentWorker.EditDocument();
        documentWorker.SaveDocument();
        }
    }
