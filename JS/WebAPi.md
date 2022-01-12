# Webservice

+ statusbehaftet
+ statusfrei

## WebAPI -> REST (Representational State Transfer)

REST ist die Schnittstelle/Definition für die HTTP Kommunikation gemappt auf die CRUD Funktionen.

1. C -> Create:     HTTP-PUT
2. R -> Retrieve:   HTTP-GET
3. U -> Update:     HTTP-POST
4. D -> Delete:     HTTP-DELETE

Bsp: Kunde mit ID 5 abrufen
`http://meinserver/meineapp/api/Customer/5`

Bsp: Alle Kunden abrufen
`http://meinserver/meineapp/api/Customers`

Die Daten werden in der Regel als XML-Daten oder JSON-Daten übermittelt.

`http://meinserver/meinTaschenrechner/api/Addition?x=10&y=20`