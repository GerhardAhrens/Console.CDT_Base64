# Custom Data Typ Base64

## Base64 - Data Typ
Bei einem Custom Data Typ "CDT" handelt es sich um eine selbst definierten Datentyp mit Eigenschaften die einen bestimmten Zweck erf�llen sollen.</br>
Ein Custom Data Typ kann wie einen *normaler* primitiver Datentyp behandelt werden. Es gibt zwei M�glichkeine um CDT zu erstellen. Als *Class* oder als *Struct*.

```csharp
public struct Base64 : IEquatable<Base64>, IComparable<Base64>
{}
```
Der Typ *Base64* implementiert das Interface *IEquatable<>* und *IComparable<>*. Dadurch wird ein spezifischer Vergleich zweier *Base64* Variablen m�glich.</br>

Warum nun aber ein eigener Typ f�r *Base64*?. Die Kodierung eines Byte Array zu Base64 ist ein String.</br>

### Zwei wichtige Gr�nde sprechen daf�r:
- **Lesbarkeit**
  Ist ein String in einem *Base64 Typ* kann amn sich daruf verlassen, das da eben auch eine Base64 kodirter String enthalten ist.
- **Erweiterbarkeit**
  Es istin einem eigenen Typ m�glich zus�tzliche Erweiterungen einzubauen, die mit der Base64-Funktionalit�t zusammen h�ngt.</br>
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
| IsNullOrEmpty     |Property| Pr�ft, ob ein Value gef�llt ist.|
| IsNull            |Property| Pr�ft, ob ein Value 'null' ist.|
| IsBase64String    |Property| Pr�ft, ob ein Value ein g�ltiger Base64 String ist.|
| Base64Encode    |Methode| Kodiert einen lesbaren String nach Base64.|
| Base64Decode    |Methode| Dekodiert einen Base64 String in einen lesbaren String zur�ck.|
| GetHashCode    |Methode| Gibt den HashCode von einem Base64 String zur�ck.|
| ToString    |Methode| Gibt den Base64 String als String zur�ck.|
| ToByteArray    |Methode| Gibt den Base64 String als ByteArray zur�ck.|

Die Klasse kann noch mit weiteren Funktionalit�ten wie z.B.
- Image nach Base64 direkt umwandeln
erweitert werden.

