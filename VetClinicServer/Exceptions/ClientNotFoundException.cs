namespace VetClinicServer.Exceptions;

public class ClientNotFoundException : ResourceNotFoundException
{
    public ClientNotFoundException()
        : base("Client not found.")
    {
    }
    public ClientNotFoundException(int clientId)
        : base($"Client with ID {clientId} not found.")
    {
    }
}