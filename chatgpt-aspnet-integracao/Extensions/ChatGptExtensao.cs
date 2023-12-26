using OpenAI_API;

namespace chatgpt_aspnet_integracao.Extensions
{
    public static class ChatGptExtensao
    {
        public static WebApplicationBuilder AddChatGpt(this WebApplicationBuilder builder /*, IConfiguration configuration*/) 
        {
            string? key = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
            //string? key = configuration["ChatGpt:Key"];
            OpenAIAPI chat = new OpenAIAPI(key);
            builder.Services.AddSingleton(chat);
            return builder;
        }
    }
}
