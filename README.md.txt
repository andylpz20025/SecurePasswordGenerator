# Secure Password Generator

Ein kryptografisch sicheres Tool zur Erzeugung von Passwörtern unter Windows.

## Sicherheitsmerkmale
- **Kryptografisch sicher:** Nutzt `System.Security.Cryptography.RandomNumberGenerator`.
- **Anti-Streaming:** Verhindert mittels `SetWindowDisplayAffinity`, dass das Programm in OBS, Discord oder via Screenshots aufgezeichnet werden kann.

## Anleitung
1. **Länge/Struktur:** Lege fest, ob du Passwörter in Blöcken (z.B. 4x4 Zeichen) oder als fortlaufende Zeichenkette generieren möchtest.
2. **Kriterien:** Wähle die gewünschten Zeichensätze (Groß-/Kleinbuchstaben, Ziffern, Sonderzeichen, Umlaute).
3. **Trennzeichen:** Wenn das Feld "Trennzeichen" leer bleibt, wird ein kompakter Block generiert. Ansonsten wird das gewählte Trennzeichen (z.B. `-`) verwendet.

## Beispiele
- **Block-Modus:** 4 Blöcke, 4 Zeichen, Trenner `-` → `ABCD-1234-EFGH-5678`
- **Kompakt-Modus:** 1 Block, 16 Zeichen, Trenner (leer) → `ABCD1234EFGH5678`

## Hinweise
- Die Anwendung schützt vor optischer Aufnahme (schwarzes Fenster bei Stream/Screenshot).
- Das Passwort steht nach Generierung im Klartext in der TextBox. Kopiere es umgehend in deinen Passwort-Manager.
- Diese Anwendung speichert keine Passwörter.