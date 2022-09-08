﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VkNet;
using VkNet.Model;

namespace DrugBot.Processors;

public class ProcessorDeadChinese : AbstractProcessor
{
    private readonly List<string> keys = new()
    {
        "/мудрец"
    };

    public override string Description =>
        $"Пророчество от мудрого, но мертвого китайца, для вызова деда используйте {string.Join(' ', keys)}";

    public override IReadOnlyList<string> Keys => keys;

    public override string Name => "Мертвый китаец";

    protected override void OnProcessMessage(VkApi vkApi, Message message, string[] sentence)
    {
        Random rnd = new(BotHandler.GetDayUserSeed(message.FromId));


        int predictionLength = (int)Math.Abs(15 + Math.Tan(0.5 * Math.PI * Math.Pow(2 * rnd.NextDouble() - 1, 5)));
        StringBuilder stringBuilder = new($"Мудрец видит что в будущем будет {GetPrediction(rnd, predictionLength)}");

        BotHandler.SendMessage(vkApi, message.PeerId, stringBuilder.ToString());
    }

    private static string GetPrediction(Random rnd, int count)
    {
        try
        {
            string path = "Local/chinese.txt";
            StringBuilder builder = new();

            List<string> predictions = File.ReadLines(path).ToList();
            for (int i = 0; i < count; i++)
                builder.AppendJoin(' ', predictions[rnd.Next(0, predictions.Count)]);

            return builder.ToString();
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }
}