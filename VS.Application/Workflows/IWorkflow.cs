namespace VS.Application.Workflows;

public interface IWorkflow
{
    void Run();
}

public interface IAsyncWorkflow
{
    Task Run();
}
