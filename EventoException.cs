// See https://aka.ms/new-console-template for more information



//MILESTONE 1

using System.Runtime.Serialization;

public class EventoException : Exception
{
    public EventoException()
    {
    }

    public EventoException(string? message) : base(message)
    {
    }

    public EventoException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected EventoException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

public class DataException : Exception
{
    public DataException()
    {
    }

    public DataException(string? message) : base(message)
    {
    }

    public DataException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected DataException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}