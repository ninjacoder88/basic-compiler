# basic-compiler


[Lexers vs Parsers](https://stackoverflow.com/questions/2842809/lexers-vs-parsers)
[Lexical Analysis](https://en.wikipedia.org/wiki/Lexical_analysis)
[Tokenizer, Lexer, Parser](https://stackoverflow.com/questions/380455/looking-for-a-clear-definition-of-what-a-tokenizer-parser-and-lexers-are)

**tokenizer**
breaks a stream of text into tokens usually by looking for whitespace (tabs, spaces, new lines, etc)

**lexer**
processes tokens adding additional context such as 
- is number
- is string literal
- is operator

**parser**
processes stream of tokens from lexer and transforms into abstract syntax tree
processing using a grammar
[Context Free Grammar](https://en.wikipedia.org/wiki/Context-free_grammar)
[Context Sensitive Grammers](https://en.wikipedia.org/wiki/Context-sensitive_grammar)

**abstract syntax tree**
[Abstract Syntax Tree](https://en.wikipedia.org/wiki/Abstract_syntax_tree)
