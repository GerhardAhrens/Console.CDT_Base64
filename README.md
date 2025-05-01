# Custom Data Typ Base64

## Base64 - Data Typ
Bei einem Custom Data Typ "CDT" handelt es sich um eine selbst definierten Datentyp mit Eigenschaften die einen bestimmten Zweck erf�llen sollen.</br>
Ein Custom Data Typ kann wie einen *normaler* primitiver Datentyp behandelt werden. Es gibt zwei M�glichkeine um CDT zu erstellen. Als *Class* oder als *Struct*.

```csharp
public struct Base64 : IEquatable<Base64>, IComparable<Base64>
{}
```
Der Typ implementiert das Interface *IEquatable<>* und *IComparable<>*.

