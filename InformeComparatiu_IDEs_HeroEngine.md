# Informe tècnic comparatiu d’IDEs per al desenvolupament de *HeroEngine OOP*

## 1. Introducció
Aquest informe presenta una comparativa tècnica entre tres entorns de desenvolupament utilitzats habitualment en projectes **C# i .NET**:

- **Visual Studio Community**
- **Visual Studio Code**
- **JetBrains Rider**

L’objectiu és analitzar quin IDE ofereix millors prestacions per al desenvolupament del projecte **HeroEngine OOP**, especialment en aspectes de **programació orientada a objectes, refactorització, depuració i escalabilitat del codi**.

---

## 2. Comparativa tècnica global

| Criteri | Visual Studio Community | Visual Studio Code | JetBrains Rider |
|---|---|---|---|
| Edició de codi | Excel·lent | Bona amb extensions | Excel·lent |
| Refactoring | Molt complet | Mitjà | Excel·lent |
| Debugger | Molt avançat | Correcte | Molt avançat |
| NuGet / Build | Natiu | Via CLI + extensió | Natiu |
| Git integrat | Excel·lent | Molt bo | Excel·lent |
| Plugins C#/Unity | Molts | Moltíssims | Molts i especialitzats |
| Rendiment | Alt consum | Molt lleuger | Equilibrat |
| Multiplataforma | Windows | Win/Mac/Linux | Win/Mac/Linux |
| Llicència | Gratuït estudiants | Gratuït | Gratuït no comercial / pagament professional |

---

## 3. Edició de codi

### Visual Studio Community
Ofereix el millor suport natiu per C#:

- IntelliSense molt madur
- snippets integrats
- navegació ràpida entre classes (`Go to Definition`)
- refactorització assistida:
  - rename
  - extract method
  - extract interface
  - move type

És especialment fort en projectes grans amb moltes classes com **CombatEngine**, **Mage** o la jerarquia d’enemics.

### Visual Studio Code
Depèn molt de l’ecosistema d’extensions:

- **C# Dev Kit**
- **C#**
- **.NET Install Tool**

Amb aquestes extensions:

- autocomplete bo
- snippets bons
- navegació acceptable
- refactoring correcte però menys profund

La principal limitació és que la refactorització complexa en arquitectures OOP és inferior.

### JetBrains Rider
És probablement el millor per a projectes OOP complexos.

Integra la tecnologia de **ReSharper**, amb:

- inspeccions contínues
- detecció de duplicació
- navegació de jerarquies
- anàlisi SOLID
- refactors avançats

En el sistema de combat polimòrfic és especialment potent.

---

## 4. Depurador

### Visual Studio Community
És el debugger més complet:

- breakpoints condicionals
- watches
- call stack
- inspecció d’objectes
- memòria
- hot reload

Ideal per depurar rondes de combat, errors de mana o selecció d’habilitats.

### Visual Studio Code
Correcte però més simple:

- breakpoints
- variables locals
- watch expressions
- call stack
- debug console

Suficient per projectes mitjans.

### JetBrains Rider
Molt proper a Visual Studio:

- async debugging
- watches avançades
- stack trace clar
- visualització d’objectes excel·lent
- breakpoints intel·ligents

Especialment bo per depurar **LINQ, col·leccions i herència**.

---

## 5. Generació d’executables

### Visual Studio Community
La millor experiència GUI:

- Debug / Release molt visual
- gestió NuGet nativa
- publicació amb assistent
- self-contained executables
- single-file publish

### Visual Studio Code
Molt més manual:

```bash
dotnet build
dotnet publish -c Release
```

Avantatges:

- control total
- ideal per entendre el pipeline .NET

### JetBrains Rider
Combina GUI i potència:

- perfils de build
- publish profiles
- NuGet integrat
- toolchain .NET
- suport Docker

---

## 6. Integració amb control de versions

### Visual Studio Community
Git integrat excel·lent:

- branques
- merges
- stash
- cherry-pick
- diff visual
- resolució de conflictes

### Visual Studio Code
Una de les seves fortaleses:

- Git molt ràpid
- diff visual net
- extensió **GitLens**
- historial clar

### JetBrains Rider
També excel·lent:

- Git
- Mercurial
- Perforce
- Subversion
- diff semàntic
- blame

Especialment útil en refactors massius.

---

## 7. Extensibilitat i ecosistema

### Visual Studio Community
Ideal per:

- Unity
- MAUI
- Azure
- testing
- SQL Server
- profiling

### Visual Studio Code
L’ecosistema més gran:

- extensions IA
- snippets
- themes
- Docker
- Markdown
- GitHub Copilot
- C# Dev Kit

### JetBrains Rider
Millor ecosistema per videojocs C#:

- Unity Support
- UnrealLink
- ReSharper tools
- database tools
- decompiler

Especialment recomanable per a videojocs i motors basats en OOP.

---

## 8. Rendiment de l’IDE

### Visual Studio Community
- arrencada lenta
- consum RAM alt
- molt estable en Windows

### Visual Studio Code
- el més ràpid
- consum baix
- ideal per portàtils modestos

### JetBrains Rider
- més ràpid que VS en projectes grans
- indexació inicial costosa
- molt fluid després

---

## 9. Multiplataforma i llicència

| IDE | Sistemes Operatius | Cost |
|---|---|---|
| Visual Studio Community | Windows | Gratuït per estudiants |
| Visual Studio Code | Windows / macOS / Linux | Gratuït |
| JetBrains Rider | Windows / macOS / Linux | Gratuït no comercial / subscripció professional |

---

## 10. Conclusions
Per al projecte **HeroEngine OOP**, la millor opció depèn de l’objectiu:

- **Visual Studio Community** → millor depuració i publicació
- **Visual Studio Code** → millor rendiment i lleugeresa
- **JetBrains Rider** → millor arquitectura, refactorització i escalabilitat

### Recomanació final
Per a un sistema amb:

- combat polimòrfic
- jerarquia d’enemics
- logs
- estadístiques
- habilitats
- refactors futurs

la millor opció tècnica és **JetBrains Rider**, mentre que **Visual Studio Community** continua sent excel·lent per a depuració profunda en Windows.

