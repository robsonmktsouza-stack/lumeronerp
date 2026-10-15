# Lumeron — Gestão Empresarial

Aplicativo **desktop nativo Windows** feito em **C# / .NET 10 / WPF**, com componentes visuais reutilizáveis.

## Projetos

- `Lumeron.Desktop`: janela principal, área de trabalho com abas e recursos do aplicativo.
- `Lumeron.UI`: controles de interface e tema visual, incluindo o Ribbon.

## Desenvolvimento

Abra `Lumeron.slnx` no Visual Studio 2026 e execute `Lumeron.Desktop`.

Requisitos: Windows e SDK do .NET 10 com a carga de trabalho de desenvolvimento desktop .NET/WPF.

A tela inicial é um **ambiente de trabalho**, não um dashboard com dados fictícios. Os comandos de Ribbon e os módulos comerciais serão conectados à medida que forem implementados.

## Identidade visual

A imagem `Lumeron.Desktop/Assets/LumeronLogo.png` é o logotipo do Lumeron. A paleta e o estilo das abas do espaço de trabalho ficam centralizados em `Lumeron.UI/Themes/LumeronTheme.xaml`.

## Observação

Os estilos do Ribbon WPF são mantidos em sua estrutura nativa. A aplicação atualmente oculta a linha superior de acesso rápido por meio de um ajuste do template visual, implementado em `LumeronRibbon.xaml.cs`. Esse ajuste deverá ser revisado caso o template nativo mude em uma atualização do WPF.
