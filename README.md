# Custom Data Typ Base64

## Base64 - Data Typ
Bei einem Custom Data Typ "CDT" handelt es sich um eine selbst definierten Datentyp mit Eigenschaften die einen bestimmten Zweck erfüllen sollen.</br>
Ein Custom Data Typ kann wie einen *normaler* primitiver Datentyp behandelt werden. Es gibt zwei Möglichkeine um CDT zu erstellen. Als *Class* oder als *Struct*.

```csharp
public struct Base64 : IEquatable<Base64>, IComparable<Base64>
{}
```
Der Typ *Base64* implementiert das Interface *IEquatable<>* und *IComparable<>*. Dadurch wird ein spezifischer Vergleich zweier *Base64* Variablen möglich.</br>

Warum nun aber ein eigener Typ für *Base64*?. Die Kodierung eines Byte Array zu Base64 ist ein String.</br>

### Zwei wichtige Gründe sprechen dafür:
- **Lesbarkeit**
  Ist ein String in einem *Base64 Typ* kann amn sich daruf verlassen, das da eben auch eine Base64 kodirter String enthalten ist.
- **Erweiterbarkeit**
  Es istin einem eigenen Typ möglich zusätzliche Erweiterungen einzubauen, die mit der Base64-Funktionalität zusammen hängt.</br>
</br>

Beispiele:
```csharp
Base64 base64String = Base64.Base64Encode("hallo Gerhard");

Base64 base64String = "aGFsbG8gR2VyaGFyZA==";

Base64 base64String = ImageToBase64(demoDataImage);
bool isValid = base64String.IsBase64String();

```
</br>

| Name  |Property/Methode| Beschreibung |
| :---------------- |:-| :----------  |
| IsNullOrEmpty     |Property| Prüft, ob ein Value gefüllt ist.|
| IsNull            |Property| Prüft, ob ein Value 'null' ist.|
| IsBase64String    |Property| Prüft, ob ein Value ein gültiger Base64 String ist.|
| Base64Encode    |Methode| Kodiert einen lesbaren String nach Base64.|
| Base64Decode    |Methode| Dekodiert einen Base64 String in einen lesbaren String zurück.|
| GetHashCode    |Methode| Gibt den HashCode von einem Base64 String zurück.|
| ToString    |Methode| Gibt den Base64 String als String zurück.|
| ToByteArray    |Methode| Gibt den Base64 String als ByteArray zurück.|

Die Klasse kann noch mit weiteren Funktionalitäten wie z.B.
- Image nach Base64 direkt umwandeln
erweitert werden.

