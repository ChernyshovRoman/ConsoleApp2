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
            await CallBack(botClient, update, token);
            await MessageHandler(botClient, update, token);


        }
        private static async Task CallBack(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update != null && update.CallbackQuery != null)
            {
                string answer = update.CallbackQuery.Data;
                switch (answer)
                {
                    case "PB":
                        await botClient.SendTextMessageAsync(update.CallbackQuery.Message.Chat.Id, "Данный тариф имеет 50/150 минут звонков и 25/50 ГБ интернета на месяц в своей базовой конфигурации он стоит 730 рублей. Отличительной чертой данного тарифа является то, что он позволяет выбрать список приложений которые не будут тратить пакет интернета. Данный тариф идеально подходит для людей которым интернет важнее звонков.");
                        InlineKeyboardMarkup inlineKeyboard = new(new[]
                        {
                        new []
                        {
                        InlineKeyboardButton.WithUrl(text: "Да", url: "https://moskva.beeline.ru/planb/"),
                        InlineKeyboardButton.WithCallbackData(text: "Нет", callbackData: "No")
                        }
                         });
                        Message sentMessage = await botClient.SendTextMessageAsync(
                        update.CallbackQuery.Message.Chat.Id,
                        text: "Вы хотите выбрать данный тариф?",
                        replyMarkup: inlineKeyboard,
                        cancellationToken: cancellationToken);

                        break;
                    case "Bee":
                        await botClient.SendTextMessageAsync(update.CallbackQuery.Message.Chat.Id, "Данный тариф по умолчанию имеет 1200 минут звонков и 50 ГБ интернета и стоит 950 рублей. Особенностью этого тарифа является скидка в 75% на подключение дополнительных номеров к тарифу, это позволяет более удобно делится минутами и ГБ.");
                        InlineKeyboardMarkup inlineKeyboard2 = new(new[]
                        {
                        new []
                        {
                        InlineKeyboardButton.WithUrl(text: "Да", url: "https://moskva.beeline.ru/customers/products/mobile/tariffs/details/up4/"),
                        InlineKeyboardButton.WithCallbackData(text: "Нет", callbackData: "No")
                        }
                         });
                        Message sentMessage2 = await botClient.SendTextMessageAsync(
                        update.CallbackQuery.Message.Chat.Id,
                        text: "Вы хотите выбрать данный тариф?",
                        replyMarkup: inlineKeyboard2,
                        cancellationToken: cancellationToken);
                        break;
                    case "Cat":
                        await botClient.SendTextMessageAsync(update.CallbackQuery.Message.Chat.Id, "Данный тариф по умолчанию имеет 1500 минут звонков и 50 ГБ интернета и стоит 1100 рублей. Особенность данного тарифа - скидка 20% на ГБ и звонки в роуминге и приоритетное обслуживание в центре поддержки клиентов Билайн.");
                        InlineKeyboardMarkup inlineKeyboard3 = new(new[]
                        {
                        new []
                        {
                        InlineKeyboardButton.WithUrl(text: "Да", url: "https://moskva.beeline.ru/customers/products/mobile/tariffs/details/up5/"),
                        InlineKeyboardButton.WithCallbackData(text: "Нет", callbackData: "No")
                        }
                         });
                        Message sentMessage3 = await botClient.SendTextMessageAsync(
                        update.CallbackQuery.Message.Chat.Id,
                        text: "Вы хотите выбрать данный тариф?",
                        replyMarkup: inlineKeyboard3,
                        cancellationToken: cancellationToken);
                        break;
                    case "Dragon":
                        await botClient.SendTextMessageAsync(update.CallbackQuery.Message.Chat.Id, "Данный тариф по умолчанию имеет 700 минут звонков и 35 ГБ интернета и стоит 850 рублей. Этот тариф выделяет то, что основной пакет интернета тарифа не будет тратиться при использовании ВКонтакте. Если пакет интернета увеличить до 40-50 ГБ, то трафик будет бесконечным и на YouTube.");
                        InlineKeyboardMarkup inlineKeyboard5 = new(new[]
                        {
                        new []
                        {
                        InlineKeyboardButton.WithUrl(text: "Да", url: "https://moskva.beeline.ru/customers/products/mobile/tariffs/details/up3/"),
                        InlineKeyboardButton.WithCallbackData(text: "Нет", callbackData: "No")
                        }
                         });
                        Message sentMessage5 = await botClient.SendTextMessageAsync(
                        update.CallbackQuery.Message.Chat.Id,
                        text: "Вы хотите выбрать данный тариф?",
                        replyMarkup: inlineKeyboard5,
                        cancellationToken: cancellationToken);
                        break;
                    case "Panda":
                        await botClient.SendTextMessageAsync(update.CallbackQuery.Message.Chat.Id, "Данный тариф по умолчанию имеет 200 минут звонков и 6 ГБ интернета и стоит 650 рублей. Особенность данного тарифа - 20% скидка на тариф для тех, кому больше 60 лет, а также защита от случайных подписок и звонков мошенников для всех. Если выбрать пакет интернета в 40-50 ГБ, то ктарифу добавятся безлимитные бесплатные звонки на Билайн.");
                        InlineKeyboardMarkup inlineKeyboard6 = new(new[]
                        {
                        new []
                        {
                        InlineKeyboardButton.WithUrl(text: "Да", url: "https://moskva.beeline.ru/customers/products/mobile/tariffs/details/up1/"),
                        InlineKeyboardButton.WithCallbackData(text: "Нет", callbackData: "No")
                        }
                         });
                        Message sentMessage6 = await botClient.SendTextMessageAsync(
                        update.CallbackQuery.Message.Chat.Id,
                        text: "Вы хотите выбрать данный тариф?",
                        replyMarkup: inlineKeyboard6,
                        cancellationToken: cancellationToken);
                        break;
                    case "Robot":
                        await botClient.SendTextMessageAsync(update.CallbackQuery.Message.Chat.Id, "Данный тариф по умолчанию имеет 400 минут звонков и 20 ГБ интернета и стоит 750 рублей. Данный тариф  делает звонки домой более выгодными: Китай — 5 ₽/мин, Узбекистан — 7 ₽/мин, Номера Team Telecom Armenia — 7 ₽/мин, Номера Beeline Казахстана и Кыргызстана, Tcell Таджикистана — 9 ₽/мин. Если увеличить пакет интернета до 40-50 ГБ, то звонки станут ещё дешевле.");
                        InlineKeyboardMarkup inlineKeyboard7 = new(new[]
                        {
                        new []
                        {
                        InlineKeyboardButton.WithUrl(text: "Да", url: "https://moskva.beeline.ru/customers/products/mobile/tariffs/details/up2/"),
                        InlineKeyboardButton.WithCallbackData(text: "Нет", callbackData: "No")
                        }
                         });
                        Message sentMessage7 = await botClient.SendTextMessageAsync(
                        update.CallbackQuery.Message.Chat.Id,
                        text: "Вы хотите выбрать данный тариф?",
                        replyMarkup: inlineKeyboard7,
                        cancellationToken: cancellationToken);
                        break;
                    case "No":
                        InlineKeyboardMarkup inlineKeyboard4 = new(new[]
                        {
                        new []
                        {
                        InlineKeyboardButton.WithCallbackData (text: "План Б", callbackData: "PB"),
                        InlineKeyboardButton.WithCallbackData (text: "Пчела Базя", callbackData: "Bee"),
                        InlineKeyboardButton.WithCallbackData (text: "Кот Пуш", callbackData: "Cat"),
                        },
                        new []
                        {
                        InlineKeyboardButton.WithCallbackData (text: "Дракон Юнг", callbackData: "Dragon"),
                        InlineKeyboardButton.WithCallbackData (text: "Панда Тапа", callbackData: "Panda"),
                        InlineKeyboardButton.WithCallbackData (text: "Робот Пинг", callbackData: "Robot")
                        }
                        });
                        Message sentMessage4 = await botClient.SendTextMessageAsync(
                        chatId: update.CallbackQuery.Message.Chat.Id,
                        text: "Наши тарифы:",
                        replyMarkup: inlineKeyboard4,
                        cancellationToken: cancellationToken);
                        break;
                }


            }
        }
        private static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }
        private static async Task MessageHandler(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {


            var message = update.Message;

            if (message == null)
                return;
            if (message.Text == null)
                return;

            var chatId = message.Chat.Id;
            if (message.Text == "/start")
            {
                botClient.SendTextMessageAsync(message.Chat.Id, "Ваши команды:\n/ServiceList (Список услуг)\n/RemoveList (Убрать список)");
            }

            if (message.Text.Contains("Привет") || message.Text.Contains("Здравствуйте"))
            {
                botClient.SendTextMessageAsync(message.Chat.Id, "Добро пожаловать в наш салон связи");
                return;
            }
            if (message.Text == "/go")
            {
                //  await ReplyButton(botClient, update);
                return;
            }

            if (message.Text == "/ServiceList")
            {
                ReplyKeyboardMarkup replyKeyboard = new(new[]
                {
                new KeyboardButton[] {"Покупка мобильного устройства"},
                new KeyboardButton[] {"Реализация сопутствующих товаров"},
                new KeyboardButton[] {"Выбор тарифов"}
           });
                await botClient.SendTextMessageAsync(chatId: chatId, text: "Вот список наших услуг", replyMarkup: replyKeyboard, cancellationToken: cancellationToken);
            }
            if (message.Text == "/RemoveList")
            {
                Message sentMessage = await botClient.SendTextMessageAsync(
                 chatId: chatId,
                 text: "Удаление кнопок",
                 replyMarkup: new ReplyKeyboardRemove(),
                 cancellationToken: cancellationToken);
            }
            if (message.Text == "Покупка мобильного устройства")
            {
                InlineKeyboardMarkup inlineKeyboard = new(new[]
                {
                new []
                {
                InlineKeyboardButton.WithUrl(text: "Телефоны", url: "https://moskva.beeline.ru/shop/catalog/telefony/smartfony/"),
                InlineKeyboardButton.WithUrl(text: "Планшеты", url: "https://moskva.beeline.ru/shop/catalog/planshety/planshety-3/")
                } 
                });
                Message sentMessage = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Варианты устройств:",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
            }
            if (message.Text == "Реализация сопутствующих товаров")
            {
                InlineKeyboardMarkup inlineKeyboard = new(new[]
                {
                new []
                    {
                InlineKeyboardButton.WithUrl(text: "Аксессуары", url: "https://moskva.beeline.ru/shop/catalog/aksessuary/luchshii-vybor/"),
                InlineKeyboardButton.WithUrl(text: "Гаджеты", url: "https://moskva.beeline.ru/shop/catalog/gadzhety/umnye-chasy-i-braslety/"),
                InlineKeyboardButton.WithUrl(text: "Аудио устройсва", url: "https://moskva.beeline.ru/shop/catalog/audio/audio-all/")
                }
                });
                Message sentMessage = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Варианты товаров:",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
            }
            if (message.Text == "Выбор тарифов")
            {
                InlineKeyboardMarkup inlineKeyboard = new(new[]
                {
                new []
                {
                InlineKeyboardButton.WithCallbackData (text: "План Б", callbackData: "PB"),
                InlineKeyboardButton.WithCallbackData (text: "Пчела Базя", callbackData: "Bee"),
                InlineKeyboardButton.WithCallbackData (text: "Кот Пуш", callbackData: "Cat")
                },
                new []
                {
                InlineKeyboardButton.WithCallbackData (text: "Дракон Юнг", callbackData: "Dragon"),
                InlineKeyboardButton.WithCallbackData (text: "Панда Тапа", callbackData: "Panda"),
                InlineKeyboardButton.WithCallbackData (text: "Робот Пинг", callbackData: "Robot")
                }
                });
                Message sentMessage = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "Наши тарифы:",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
            }
        }
    }
}