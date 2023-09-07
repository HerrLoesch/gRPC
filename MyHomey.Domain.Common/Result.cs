namespace MyHomey.Domain.Common;

public record Result(Successful bool, Failure? Failure);

public record Failure(string FailureCode, string DisplayName, string Description, bool IsBusy);

public class Event<T>
{
    DateTime CreationDate {get;}

    string DisplayName {get; protected set; }

    T Payload {get; protected set; }

    public Event<T>()
    {
        CreationDate = DateTime.Now;
    }

    public Event<T>(DateTime creationDate)
    {
        this.CreationDate = creationDate;
    }
}