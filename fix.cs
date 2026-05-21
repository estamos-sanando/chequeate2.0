using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class Program {
    static void Main() {
        string file = "index.html";
        string content = File.ReadAllText(file, Encoding.UTF8);

        var replacements = new Dictionary<string, string> {
            { "ðŸ©º", "🩺" },
            { "ðŸš‘", "🚑" },
            { "ðŸ§ ", "🧠" },
            { "ðŸ©¸", "🩸" },
            { "ðŸ ¥", "🏥" },
            { "ðŸ“‹", "📋" },
            { "ðŸ˜¢", "😢" },
            { "ðŸ˜•", "😕" },
            { "ðŸ˜ ", "😐" },
            { "ðŸ˜Š", "😊" },
            { "ðŸ˜„", "😄" },
            { "ðŸ˜´", "😴" },
            { "ðŸŒŸ", "🌟" },
            { "ðŸ“…", "📅" },
            { "ðŸ“ ", "📈" },
            { "ðŸ‘ ï¸ ", "👁️" },
            { "👁ï¸ ", "👁️" },
            { "ðŸ¦·", "🦷" },
            { "ðŸ”¬", "🔬" },
            { "ðŸ§ª", "🧪" },
            { "ðŸŒ¸", "🌸" },
            { "ðŸ¥—", "🥗" },
            { "â ¤ï¸ ", "❤️" },
            { "âš—ï¸ ", "⚕️" },
            { "ðŸ§˜", "🧘" },
            { "ðŸ¦´", "🦴" },
            { "ðŸš¶", "🚶" },
            { "ðŸ’§", "💧" },
            { "ðŸ¥¦", "🥦" },
            { "ðŸŒ³", "🌳" },
            { "ðŸ“µ", "📵" },
            { "ðŸ†”", "🆔" },
            { "ðŸ“Š", "📊" },
            { "ðŸš¨", "🚨" },
            { "ðŸ“ˆ", "📈" },
            { "ðŸ’ª", "💪" },
            { "ðŸ ƒ", "🏃" },
            { "ðŸš­", "🚭" },
            { "ðŸ§¬", "🧬" },
            { "ðŸ“Œ", "📌" },
            { "ðŸ‘¤", "👤" },
            { "ðŸ’Š", "💊" },
            { "ðŸ  ", "🏠" },
            { "â€¢", "•" },
            { "âœ…", "✅" }
        };

        foreach (var kvp in replacements) {
            content = content.Replace(kvp.Key, kvp.Value);
        }

        File.WriteAllText(file, content, new UTF8Encoding(false));
        Console.WriteLine("Replaced successfully.");
    }
}
