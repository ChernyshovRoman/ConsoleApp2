using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types.ReplyMarkups;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Start();
            Console.ReadLine();
        }
       private async static void Start()
        {
            var client = new TelegramBotClient("7155657438:AAHarRl-5Yq2CWlR_c228LriDeC36H6-ykU");
            client.StartReceiving(Update, Error);
           
        }


        async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
            var message = update.Message;
            if (message.Text != null && message != null)
            {
                if (message.Text.Contains("Привет") || message.Text.Contains("Здравствуйте"))
                {
                    botClient.SendTextMessageAsync(message.Chat.Id, "Здравствуйте");
                    return;
                }
                if(message.Text == "/go")
                {
                    await ReplyButton(botClient, update);
                    return;
                }
            }

        }
        async static Task ReplyButton(ITelegramBotClient botClient, Update update)
        {
            var message = update.Message;
            var chatId = message.Chat.Id;
            ReplyKeyboardMarkup replyKeyboard = new(new[]
            {
                new KeyboardButton[] {"f[f[f[f"},
                new KeyboardButton[] {"rrrrrrrr"},
                new KeyboardButton[] {"bbbbbbb"},
                new KeyboardButton[] {"aaaaaa"}
           });
            await botClient.SendTextMessageAsync(chatId, "", replyMarkup: replyKeyboard);
            //var replies = new(new[] { 
            //    new KeyboardButton[] { "1" },
            //    new KeyboardButton[] { "2" },
            //    new KeyboardButton[] { "3" },
            //    new KeyboardButton[] { "4" } })
            //    { ResizeKeyboard = true };
            if (message.Text == "1")
            {
                await botClient.SendTextMessageAsync(chatId, "a");
            }
            if (message.Text == "2")
            {
                await botClient.SendTextMessageAsync(chatId, "b");
            }
            if (message.Text == "3")
            {
                await botClient.SendTextMessageAsync(chatId, "c");
            }
            if (message.Text == "4")
            {
                await botClient.SendTextMessageAsync(chatId, "d");
            }
        }
        
        async static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {

        }
    }
}