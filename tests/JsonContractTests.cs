using System.Text.Json.Nodes;
using Newtonsoft.Json;
using Sber.SmartApp.Models.Constants;

namespace Sber.SmartApp.Models.Tests;

public class JsonContractTests
{
    [Fact]
    public void RequestRoundTripsWithExactWireNames()
    {
        const string json = """
            {
              "messageName": "POLICY_RUN_APP",
              "sessionId": "session-1",
              "messageId": 5000000000,
              "uuid": { "userChannel": "test", "sub": "subject", "userId": "sample" },
              "payload": {
                "app_info": {
                  "projectId": "9a6fe4a5-58df-4f72-9540-107c4f27ec74",
                  "applicationId": null,
                  "appversionId": "c583ab5a-4d1c-4f64-a56b-5d66e8c71fa4",
                  "frontendType": "voice",
                  "frontendEndpoint": "example",
                  "systemName": "test-system",
                  "frontendStateId": "frontend-state"
                },
                "intent": "greet",
                "original_intent": "start",
                "meta": { "time": { "timezone_id": "Europe/Moscow", "timezone_offset_sec": 10800, "timestamp": 1712345678901 } },
                "projectName": "TestApp",
                "device": {
                  "platformType": "test",
                  "platformVersion": "1",
                  "surface": "test-surface",
                  "surfaceVersion": "2",
                  "deviceId": "device-1",
                  "deviceManufacturer": "test-manufacturer",
                  "deviceModel": "test-model",
                  "features": { "appTypes": ["voice"] },
                  "capabilities": {
                    "screen": { "available": true },
                    "mic": { "available": true },
                    "speak": { "available": false }
                  }
                },
                "new_session": true,
                "character": { "id": "test", "name": "Test", "gender": "test", "appeal": "test" },
                "strategies": { "happy_birthday": true, "last_call": 1712345678901, "is_alice": true },
                "annotations": {
                  "censor_data": { "classes": ["test"], "probas": [0.75] },
                  "text_sentiment": null,
                  "asr_sentiment": { "classes": ["positive"], "probas": [0.25] }
                },
                "message": { "original_text": "Привет", "normalized_text": "привет", "asr_normalized_message": "привет" }
              }
            }
            """;

        var request = Deserialize<Request>(json);

        Assert.Equal(MessageNameValues.PolicyRunApp, request.MessageName);
        Assert.Equal(5000000000, request.MessageId);
        Assert.Equal(Guid.Parse("c583ab5a-4d1c-4f64-a56b-5d66e8c71fa4"), request.Payload.AppInfo.AppversionId);
        Assert.True(request.Payload.Strategies.IsAlice);
        Assert.Equal("Привет", request.Payload.Message.OriginalText);
        AssertJsonEqual(json, Serialize<ContractBase>(request));
    }

    [Fact]
    public void ResponseSerializedThroughBaseTypeKeepsPayloadAndWireValues()
    {
        ContractBase response = new Response
        {
            MessageName = MessageNameValues.AnswerToUser,
            SessionId = "session-1",
            MessageId = 42,
            Payload = new ResponsePayload
            {
                PronounceText = "<speak>Привет</speak>",
                PronounceTextType = PronounceTextTypeValues.Ssml,
                Emotion = new Emotion { EmotionId = EmotionIdValues.OkPrinyato },
                AutoListening = true,
                ProjectName = "TestApp",
                Items =
                [
                    new PayloadItem
                    {
                        Bubble = new Bubble { Text = "Привет", Markdown = true, ExpandPolicy = ExpandPolicyValues.ForceExpand },
                        Card = new Card
                        {
                            Type = CardTypeValues.GridCard,
                            Columns = 2,
                            ItemWidth = ItemWidthValues.Medium,
                            Items =
                            [
                                new CardCell
                                {
                                    Type = CellTypeValues.TextCellView,
                                    TopText = new CardCellText
                                    {
                                        Type = CellTypeValues.TextCellView,
                                        Text = "Текст",
                                        Typeface = TypefaceValues.ParagraphText1,
                                        TextColor = TextColorValues.Secondary,
                                        MaxLines = 3,
                                        Margins = new Margins { Top = IndentValues.X2 }
                                    },
                                    Paddings = new Paddings { Left = IndentValues.X4 },
                                    Actions = [new Models.Action { Type = ActionTypeValues.DeepLink, DeepLink = "example://test" }]
                                }
                            ]
                        }
                    }
                ],
                Suggestions = new Suggestion
                {
                    Buttons = [new Button { Title = "Дальше", Action = new Models.Action { Type = ActionTypeValues.Text, Text = "Дальше" } }]
                }
            }
        };

        const string json = """
            {
              "messageName": "ANSWER_TO_USER",
              "sessionId": "session-1",
              "messageId": 42,
              "uuid": null,
              "payload": {
                "pronounceText": "<speak>Привет</speak>",
                "pronounceTextType": "application/ssml",
                "emotion": { "emotionId": "ok_prinyato" },
                "auto_listening": true,
                "finished": false,
                "intent": null,
                "projectName": "TestApp",
                "device": null,
                "items": [{
                  "bubble": { "text": "Привет", "markdown": true, "expand_policy": "force_expand" },
                  "card": {
                    "type": "grid_card",
                    "columns": 2,
                    "item_width": "medium",
                    "items": [{
                      "type": "text_cell_view",
                      "top_text": {
                        "type": "text_cell_view", "text": "Текст", "typeface": "paragraphText1",
                        "text_color": "secondary", "max_lines": 3,
                        "margins": { "top": "2x", "left": null, "right": null, "bottom": null }
                      },
                      "bottom_text": null,
                      "paddings": { "top": null, "left": "4x", "right": null, "bottom": null },
                      "actions": [{ "type": "deep_link", "text": null, "deep_link": "example://test" }]
                    }]
                  }
                }],
                "suggestions": {
                  "buttons": [{
                    "title": "Дальше", "action": { "type": "text", "text": "Дальше", "deep_link": null }, "actions": null
                  }]
                }
              }
            }
            """;

        AssertJsonEqual(json, Serialize(response));
        AssertJsonEqual(json, Serialize(Deserialize<Response>(json)));
    }

    [Fact]
    public void PayloadItemDistinguishesMissingMembersFromExplicitNulls()
    {
        var missing = Deserialize<PayloadItem>("{}");
        var explicitNulls = Deserialize<PayloadItem>("""{"card":null,"bubble":null}""");

        Assert.NotNull(missing.Card);
        Assert.NotNull(missing.Bubble);
        Assert.Null(explicitNulls.Card);
        Assert.Null(explicitNulls.Bubble);
    }

    [Fact]
    public void RequestAcceptsQuotedNumbersAndIgnoresUnknownFields()
    {
        var request = Deserialize<Request>("""
            {
              "messageId": "5000000000",
              "futureField": true,
              "payload": {
                "meta": { "time": { "timezone_offset_sec": "10800", "timestamp": "1712345678901" } },
                "strategies": { "last_call": "1712345678901" },
                "annotations": { "censor_data": { "probas": ["0.75"] } }
              }
            }
            """);

        Assert.Equal(5000000000, request.MessageId);
        Assert.Equal(10800, request.Payload.Meta.Time.TimezoneOffsetSec);
        Assert.Equal(1712345678901, request.Payload.Meta.Time.Timestamp);
        Assert.Equal(1712345678901, request.Payload.Strategies.LastCall);
        Assert.Equal(0.75f, Assert.Single(request.Payload.Annotations.CensorData.Probas));
    }

    [Fact]
    public void CardAcceptsQuotedNumbers()
    {
        var card = Deserialize<Card>("""{"columns":"2","items":[{"top_text":{"max_lines":"3"}}]}""");

        Assert.Equal(2, card.Columns);
        Assert.Equal(3, Assert.Single(card.Items).TopText.MaxLines);
    }

    private static T Deserialize<T>(string json) => JsonConvert.DeserializeObject<T>(json)!;

    private static string Serialize<T>(T value) => JsonConvert.SerializeObject(value);

    private static void AssertJsonEqual(string expected, string actual) =>
        Assert.True(JsonNode.DeepEquals(JsonNode.Parse(expected), JsonNode.Parse(actual)), actual);
}
