$file = "index.html"
$content = [System.IO.File]::ReadAllText($file, [System.Text.Encoding]::UTF8)

$replacements = @{
    "ðŸ©º" = "🩺"
    "ðŸš‘" = "🚑"
    "ðŸ§ " = "🧠"
    "ðŸ©¸" = "🩸"
    "ðŸ ¥" = "🏥"
    "ðŸ“‹" = "📋"
    "ðŸ˜¢" = "😢"
    "ðŸ˜•" = "😕"
    "ðŸ˜ " = "😐"
    "ðŸ˜Š" = "😊"
    "ðŸ˜„" = "😄"
    "ðŸ˜´" = "😴"
    "ðŸŒŸ" = "🌟"
    "ðŸ“…" = "📅"
    "ðŸ“ " = "📈"
    "ðŸ‘ ï¸ " = "👁️"
    "ðŸ¦·" = "🦷"
    "ðŸ”¬" = "🔬"
    "ðŸ§ª" = "🧪"
    "ðŸŒ¸" = "🌸"
    "ðŸ¥—" = "🥗"
    "â ¤ï¸ " = "❤️"
    "âš—ï¸ " = "⚕️"
    "ðŸ§˜" = "🧘"
    "ðŸ¦´" = "🦴"
    "ðŸš¶" = "🚶"
    "ðŸ’§" = "💧"
    "ðŸ¥¦" = "🥦"
    "ðŸŒ³" = "🌳"
    "ðŸ“µ" = "📵"
    "ðŸ†”" = "🆔"
    "ðŸ“Š" = "📊"
    "ðŸš¨" = "🚨"
    "ðŸ“ˆ" = "📈"
    "ðŸ’ª" = "💪"
    "ðŸ ƒ" = "🏃"
    "ðŸš­" = "🚭"
    "ðŸ§¬" = "🧬"
    "ðŸ“Œ" = "📌"
    "ðŸ‘¤" = "👤"
    "ðŸ’Š" = "💊"
    "ðŸ  " = "🏠"
}

foreach ($key in $replacements.Keys) {
    $content = $content.Replace($key, $replacements[$key])
}

# There is also "👁ï¸ " which was visible in the view_file of index.html
# Wait, "👁ï¸ " was rendered by the system viewer, meaning the viewer recognized "👁" (U+1F441) and literal "ï¸ " (U+00EF U+00B8).
# But in `emojis.txt` we have `ðŸ‘ ï¸ `. Let's add the literal "👁ï¸ " too just in case.
$content = $content.Replace("👁ï¸ ", "👁️")
# Also the eye might just be 👁️
$content = $content.Replace("â ¤ï¸ ", "❤️")
$content = $content.Replace("âš—ï¸ ", "⚕️")

[System.IO.File]::WriteAllText($file, $content, [System.Text.Encoding]::UTF8)
