using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class Program {
    static void Main() {
        string file = "index.html";
        string content = File.ReadAllText(file, Encoding.UTF8);

        // Replace Line 1714
        content = Regex.Replace(content, 
            @"const map = \{ 'cardio': '.*?', 'ofta': '.*?', 'dent': '.*?', 'derm': '.*?', 'sangre': '.*?', 'gine': '.*?', 'nutri': '.*?', 'endoc': '.*?',", 
            "const map = { 'cardio': '❤️', 'ofta': '👁️', 'dent': '🦷', 'derm': '🔬', 'sangre': '🧪', 'gine': '🌸', 'nutri': '🥗', 'endoc': '⚕️',");

        // We already fixed lines 1590-1600 successfully with multi_replace_file_content!

        // Replace other garbled strings found in earlier search
        content = content.Replace("â€¢", "•");
        content = content.Replace("âœ…", "✅");

        // The Notification and other strings
        content = Regex.Replace(content, @"icon:\s*'.*?',\s*title:\s*'Control de Lunares", "icon:'🔬', title:'Control de Lunares");
        content = Regex.Replace(content, @"icon:\s*'.*?',\s*title:\s*'¡Seguí así!'", "icon:'✅', title:'¡Seguí así!'");
        content = Regex.Replace(content, @"new Notification\('.*? Chequeate", "new Notification('🏥 Chequeate");
        content = Regex.Replace(content, @"<div class=""insight-card positive"">.*? Todo parece estar en orden", "<div class=\"insight-card positive\">✅ Todo parece estar en orden");
        content = Regex.Replace(content, @"text:\s*'.*? Registraste estrés elevado", "text: '🧠 Registraste estrés elevado");
        content = Regex.Replace(content, @"text:\s*'.*? ¡Tu nivel de energía", "text: '🌟 ¡Tu nivel de energía");
        content = Regex.Replace(content, @"doc\.text\(`.*? \$\{e\.nombre\}", "doc.text(`• ${e.nombre}");
        content = Regex.Replace(content, @"doc\.text\(`.*? \$\{formatDate\(t\.fecha\)\}", "doc.text(`• ${formatDate(t.fecha)}");
        content = Regex.Replace(content, @"doc\.text\(`.*? \$\{formatDate\(h\.fecha\)\}", "doc.text(`• ${formatDate(h.fecha)}");
        content = Regex.Replace(content, @"\*\Alergias:\*\s*\$\{p\.alergias", "🚨 *Alergias:* ${p.alergias");

        // Emojis on lines 1049-1053
        content = Regex.Replace(content, @"data-val="".*?""\s*onclick=""selectEmoji\('animo','.*?'\)""", "data-val=\"$1\" onclick=\"selectEmoji('animo','$1')\""); // Wait, need to know what they were.
        // Actually they were 😢, 😕, 😐, 😊, 😄
        // Let's replace the whole block of animo emojis
        content = Regex.Replace(content, @"<div class=""emoji-btn"" data-val="".*?"" onclick=""selectEmoji\('animo','.*?'\)"">.*?</div>\s*<div class=""emoji-btn"" data-val="".*?"" onclick=""selectEmoji\('animo','.*?'\)"">.*?</div>\s*<div class=""emoji-btn"" data-val="".*?"" onclick=""selectEmoji\('animo','.*?'\)"">.*?</div>\s*<div class=""emoji-btn"" data-val="".*?"" onclick=""selectEmoji\('animo','.*?'\)"">.*?</div>\s*<div class=""emoji-btn"" data-val="".*?"" onclick=""selectEmoji\('animo','.*?'\)"">.*?</div>", 
            "<div class=\"emoji-btn\" data-val=\"😢\" onclick=\"selectEmoji('animo','😢')\">😢</div>\n<div class=\"emoji-btn\" data-val=\"😕\" onclick=\"selectEmoji('animo','😕')\">😕</div>\n<div class=\"emoji-btn\" data-val=\"😐\" onclick=\"selectEmoji('animo','😐')\">😐</div>\n<div class=\"emoji-btn\" data-val=\"😊\" onclick=\"selectEmoji('animo','😊')\">😊</div>\n<div class=\"emoji-btn\" data-val=\"😄\" onclick=\"selectEmoji('animo','😄')\">😄</div>");

        File.WriteAllText(file, content, new UTF8Encoding(false));
        Console.WriteLine("Replaced successfully with Regex.");
    }
}
