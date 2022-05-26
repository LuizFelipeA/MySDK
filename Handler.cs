namespace MySdk.Core;

public class Handler
{
    public async Task<Response> HandleAsync(Request request)
    {
        await Task.Delay(1);
        return new Response { Message = $"Account created! {request.Email}" };
    }
}
