using System.Collections;



using System;

namespace NReact.Csx {



public sealed partial class Parser 
{
	public const int _EOF = 0;
	public const int _ident = 1;
	public const int _intCon = 2;
	public const int _realCon = 3;
	public const int _charCon = 4;
	public const int _stringCon = 5;
	public const int _abstract = 6;
	public const int _async = 7;
	public const int _await = 8;
	public const int _as = 9;
	public const int _base = 10;
	public const int _bool = 11;
	public const int _break = 12;
	public const int _byte = 13;
	public const int _case = 14;
	public const int _catch = 15;
	public const int _char = 16;
	public const int _checked = 17;
	public const int _class = 18;
	public const int _const = 19;
	public const int _continue = 20;
	public const int _decimal = 21;
	public const int _default = 22;
	public const int _delegate = 23;
	public const int _do = 24;
	public const int _double = 25;
	public const int _else = 26;
	public const int _enum = 27;
	public const int _event = 28;
	public const int _explicit = 29;
	public const int _extern = 30;
	public const int _false = 31;
	public const int _finally = 32;
	public const int _fixed = 33;
	public const int _float = 34;
	public const int _for = 35;
	public const int _foreach = 36;
	public const int _goto = 37;
	public const int _if = 38;
	public const int _implicit = 39;
	public const int _in = 40;
	public const int _int = 41;
	public const int _interface = 42;
	public const int _internal = 43;
	public const int _is = 44;
	public const int _lock = 45;
	public const int _long = 46;
	public const int _namespace = 47;
	public const int _new = 48;
	public const int _null = 49;
	public const int _object = 50;
	public const int _operator = 51;
	public const int _outKW = 52;
	public const int _override = 53;
	public const int _params = 54;
	public const int _private = 55;
	public const int _protected = 56;
	public const int _public = 57;
	public const int _readonly = 58;
	public const int _ref = 59;
	public const int _return = 60;
	public const int _sbyte = 61;
	public const int _sealed = 62;
	public const int _short = 63;
	public const int _sizeof = 64;
	public const int _stackalloc = 65;
	public const int _static = 66;
	public const int _string = 67;
	public const int _struct = 68;
	public const int _switch = 69;
	public const int _this = 70;
	public const int _throw = 71;
	public const int _true = 72;
	public const int _try = 73;
	public const int _typeof = 74;
	public const int _uint = 75;
	public const int _ulong = 76;
	public const int _unchecked = 77;
	public const int _unsafe = 78;
	public const int _ushort = 79;
	public const int _usingKW = 80;
	public const int _virtual = 81;
	public const int _void = 82;
	public const int _volatile = 83;
	public const int _while = 84;
	public const int _and = 85;
	public const int _andassgn = 86;
	public const int _arrow = 87;
	public const int _assgn = 88;
	public const int _colon = 89;
	public const int _comma = 90;
	public const int _dec = 91;
	public const int _divassgn = 92;
	public const int _dot = 93;
	public const int _dblcolon = 94;
	public const int _eq = 95;
	public const int _gt = 96;
	public const int _gteq = 97;
	public const int _inc = 98;
	public const int _lbrace = 99;
	public const int _lbrack = 100;
	public const int _lpar = 101;
	public const int _lshassgn = 102;
	public const int _lt = 103;
	public const int _ltlt = 104;
	public const int _minus = 105;
	public const int _minusassgn = 106;
	public const int _modassgn = 107;
	public const int _neq = 108;
	public const int _not = 109;
	public const int _nullCoal = 110;
	public const int _orassgn = 111;
	public const int _plus = 112;
	public const int _plusassgn = 113;
	public const int _question = 114;
	public const int _rbrace = 115;
	public const int _rbrack = 116;
	public const int _rpar = 117;
	public const int _scolon = 118;
	public const int _tilde = 119;
	public const int _times = 120;
	public const int _timesassgn = 121;
	public const int _xorassgn = 122;
	public const int _andand = 123;
	public const int _lteq = 124;
	public const int _closeTag = 125;
	public const int _endTag = 126;
	public const int _from = 127;
	public const int _where = 128;
	public const int _join = 129;
	public const int _on = 130;
	public const int _equals = 131;
	public const int _into = 132;
	public const int _let = 133;
	public const int _orderby = 134;
	public const int _ascending = 135;
	public const int _descending = 136;
	public const int _select = 137;
	public const int _group = 138;
	public const int _by = 139;
	public const int maxT = 146;
	public const int _ppDefine = 147;
	public const int _ppUndef = 148;
	public const int _ppIf = 149;
	public const int _ppElif = 150;
	public const int _ppElse = 151;
	public const int _ppEndif = 152;
	public const int _ppLine = 153;
	public const int _ppError = 154;
	public const int _ppWarning = 155;
	public const int _ppRegion = 156;
	public const int _ppEndReg = 157;
	public const int _ppPragma = 158;

  const bool T = true;
  const bool x = false;
  const int minErrDist = 2;
  
  public readonly Scanner Scanner;
  public readonly Errors  Errors = new Errors();

  public Token t;    // last recognized token
  public Token la;   // lookahead token
  int errDist = minErrDist;

ArrayList ccs = new ArrayList();

public void AddConditionalCompilationSymbols(string[] symbols) {
  if (symbols != null) {
    for (int i=0; i<symbols.Length; ++i) {
      symbols[i] = symbols[i].Trim();
      if (symbols[i].Length > 0 && !ccs.Contains(symbols[i])) {
        ccs.Add(symbols[i]);
      }
    }
  }
}

// returns the end of the whitespaces in the given
// string if whitespaces is true otherwise returns
// the end of the non-whitespaces.
int EndOf(string symbol, int start, bool whitespaces) {
  while ((start < symbol.Length) && (Char.IsWhiteSpace(symbol[start]) ^ !whitespaces)) {
    ++start;
  }

  return start;
}

// input:        "#" {ws} directive ws {ws} {not-newline} {newline}
// valid input:  "#" {ws} directive ws {ws} {non-ws} {ws} {newline}
// output:       {non-ws}
string RemPPDirective(string symbol) {
  int start = 1;
  int end;

  // skip {ws}
  start = EndOf(symbol, start, true);
  // skip directive
  start = EndOf(symbol, start, false);
  // skip ws {ws}
  start = EndOf(symbol, start, true);
  // search end of symbol
  end = EndOf(symbol, start, false);
  
  return symbol.Substring(start, end - start);
}

void AddCCS(string symbol) {
  symbol = RemPPDirective(symbol);
  if (!ccs.Contains(symbol)) {
    ccs.Add(symbol);
  }
}

void RemCCS(string symbol) {
  ccs.Remove(RemPPDirective(symbol));
}


// preprocessor expression parser start
bool PPOrExpression(PPScanner scan) {
  bool e1, e2;
  
  e1 = PPAndExpression(scan);
  while (scan.peek().getKind() == PPToken.eOr) {
    scan.next();
    e2 = PPAndExpression(scan);
    e1 = e1 || e2;
  }
  
  return e1;
}

bool PPAndExpression(PPScanner scan) {
  bool e1, e2;
  e1 = PPEqualityExpression(scan);
  
  while (scan.peek().getKind() == PPToken.eAnd) {
    scan.next();
    e2 = PPEqualityExpression(scan);
    e1 = e1 && e2;
  }
  
  return e1;
}

bool PPEqualityExpression(PPScanner scan) {
  bool e1, e2;
  
  e1 = PPUnaryExpression(scan);
  int tk = scan.peek().getKind();
  
  while (tk == PPToken.eEQ || tk == PPToken.eNE) {
    scan.next();
    e2 = PPUnaryExpression(scan);
    if (tk == PPToken.eEQ) {
      e1 = e1 == e2;
    } else {
      // tk == PPToken.eNE
      e1 = e1 != e2;
    }
    tk = scan.peek().getKind();
  }
  
  return e1;
}

bool PPUnaryExpression(PPScanner scan) {
  bool not = false;
  PPToken ppt = scan.peek();
  
  while (ppt.getKind() == PPToken.eNot) {
    scan.next();
    not = !not;
    ppt = scan.peek();
  }
  
  return not ^ PPPrimaryExpression(scan);
}

bool PPPrimaryExpression(PPScanner scan) {
  bool e = false;
  PPToken ppt = scan.next();
  
  if (ppt.getKind() == PPToken.eTrue) {
    e = true;
  } else if (ppt.getKind() == PPToken.eFalse) {
    e = false;
  } else if (ppt.getKind() == PPToken.eLPar) {
    e = PPOrExpression(scan);
    ppt = scan.next();
    if (ppt.getKind() != PPToken.eRPar) {
      Error("Corrupt preprocessor directive (')' expected), found: " + ppt.toString());
    }
  } else if (ppt.getKind() == PPToken.eIdent) {
    e = ccs.Contains(ppt.getValue());
  } else {
    Error("Corrupt preprocessor directive, unknown start of PPPrimaryExpression: " + ppt.toString());
  }
  
  return e;
}
// preprocessor expression parser end

// ccs.Contains(RemPPDirective(symbol))
bool IsCCS(string symbol) {
  // skip "#" "if", "#" "elif"
  PPScanner scan = new PPScanner(symbol);
  PPToken ppt = scan.next();
  if (ppt.getKind() != PPToken.eHash) {
      Error("Corrupt preprocessor directive, # expected, but found: " + ppt.toString());
  }
  ppt = scan.next();
  if (ppt.getKind() != PPToken.eIdent) {
      Error("Corrupt preprocessor directive, identifier expected, but found: " + ppt.toString());
  }
  return PPOrExpression(scan);
}

// search for the correct alternative and enter
// drop everything before the correct alternative
void IfPragma(string symbol) {
  if (!IsCCS(symbol)) { 
    int state = 0;
    Token cur = ScanOrPeek();
    
    for (;;) {
      switch (cur.kind) {
        case _ppIf: ++state; break;
        case _ppEndif:
          if (state == 0) { return; }
          --state;
        break;
        case _ppElif:
          if (state == 0 && IsCCS(cur.val)) { return; }
        break;
        case _ppElse:
          if (state == 0) { return; }
        break;
        case _EOF: Error("Incomplete file."); return;
        default: break;
      }
      cur = ScanOrPeek();
    }
  }
}

// drop everything until the end of this if, elif, else directive
void ElifOrElsePragma() {
  int state = 0;
  Token cur = ScanOrPeek();
  
  for (;;) {
    switch (cur.kind) {
      case _ppIf: ++state; break;
      case _ppEndif:
        if (state == 0) { return; }
        --state;
      break;
      case _EOF: Error("Incomplete file."); return;
      default: break;
    }
    cur = ScanOrPeek();
  }
}

public class PPScanner {
	private const int cEOF = -1;
	private char[] fChars;
	private int fPos;
	private PPToken fNext;
	private int fChar;
	// all start characters of symbol tokens (non ident tokens).
	private readonly char[] fSymbolTokenStart = { '#', '!', '=', '&', '|', '(', ')' }; 

	public PPScanner(string str) {
		fChars = str.ToCharArray();
		fPos = 0;
		fNext = null;
		nextCh();
	}

	private void nextCh() {
		if (fPos < fChars.Length) {
			fChar = fChars[fPos];
			++fPos;
		} else {
			fChar = -1;
		}
	}

	private string readIdent() {
		System.Text.StringBuilder sb = new System.Text.StringBuilder();
		do {
			sb.Append((char) fChar);
			nextCh();
		} while (fChar != cEOF && !Char.IsWhiteSpace((char) fChar) && !isSymbolTokenStart((char) fChar));
		return sb.ToString();
	}

	private bool isSymbolTokenStart(char c) {
		for (int i = 0; i < fSymbolTokenStart.Length; ++i) {
			if (fSymbolTokenStart[i] == c) {
				return true;
			}
		}
		return false;
	}

	private PPToken scan() {
		PPToken t = new PPToken();
		while (fChar != cEOF && Char.IsWhiteSpace((char) fChar)) {
			// Skip whitespaces
			nextCh();
		}
		switch (fChar) {
		case '#':
			t.setKind(PPToken.eHash);
			nextCh();
			break;
		case '!':
			t.setKind(PPToken.eNot);
			nextCh();
			if (fChar == '=') {
				t.setKind(PPToken.eNE);
				nextCh();
			}
			break;
		case '=':
			t.setKind(PPToken.eAssign);
			nextCh();
			if (fChar == '=') {
				t.setKind(PPToken.eEQ);
				nextCh();
			}
			break;
		case '&':
			nextCh();
			if (fChar == '&') {
				nextCh();
				t.setKind(PPToken.eAnd);
			} else {
				t.setKind(PPToken.eError);
			}
			break;
		case '|':
			nextCh();
			if (fChar == '|') {
				nextCh();
				t.setKind(PPToken.eOr);
			} else {
				t.setKind(PPToken.eError);
			}
			break;
		case '(':
			t.setKind(PPToken.eLPar);
			nextCh();
			break;
		case ')':
			t.setKind(PPToken.eRPar);
			nextCh();
			break;
		case cEOF:
			t.setKind(PPToken.eEOF);
			break;
		default:
			String val = readIdent();
			if (val.Equals("true")) {
				t.setKind(PPToken.eTrue);
			} else if (val.Equals("false")) {
				t.setKind(PPToken.eFalse);
			} else {
				t.setKind(PPToken.eIdent);
				t.setValue(val);
			}
			break;
		}
		return t;
	}

	public PPToken peek() {
		if (fNext == null) {
			fNext = scan();
		}
		return fNext;
	}

	public PPToken next() {
		PPToken t;
		if (fNext != null) {
			t = fNext;
			fNext = null;
		} else {
			t = scan();
		}
		return t;
	}
}

public class PPToken {
	public const int eEOF    = 0;
	public const int eHash   = 1;
	public const int eNot    = 2;
	public const int eAssign = 3;
	public const int eAnd    = 4;
	public const int eOr     = 5;
	public const int eLPar   = 6;
	public const int eRPar   = 7;
	public const int eTrue   = 8;
	public const int eFalse  = 9;
	public const int eIdent  = 10;
	public const int eEQ     = 11;
	public const int eNE     = 12;
	public const int eError  = 13;

	private readonly string[] sfTokenNames = {"EOF", "#", "!", "=", "&&", "||", "(",
			")", "true", "false", "Identifier", "==", "!=", "Error"};
	private const string cUnknownToken = "Unknown Token";
	
	private int fKind;
	public string fVal;
	
	public void setKind(int kind) {
		fKind = kind;
	}
	
	public int getKind() {
		return fKind;
	}
	
	public void setValue(string value) {
		fVal = value;
	}
	
	public string getValue() {
		return fVal;
	}
	
	public string toString() {
		string s;
		if (fKind >= 0 && fKind < sfTokenNames.Length) {
			s = sfTokenNames[fKind];
			if (fKind == eIdent) {
				s = s + ": " + fVal;
			}
		} else {
			s = cUnknownToken;
		}
		return s;
	}
}

/*----------------------------- token sets -------------------------------*/

const int maxTerminals = 160;  // set size

static BitArray NewSet(int[] values) {
  BitArray a = new BitArray(maxTerminals);
  foreach (int x in values) a[x] = true;
  return a;
}

static BitArray
  typeDeclStart= NewSet(new int[] {_class, _struct, _interface, _enum, _delegate}),
  typeKW       = NewSet(new int[] {_char, _bool, _object, _string, _sbyte, _byte, _short,
                 _ushort, _int, _uint, _long, _ulong, _float, _double, _decimal}),
  unaryHead    = NewSet(new int[] {_plus, _minus, _not, _tilde, _times, _inc, _dec, _and}),
  assnStartOp  = NewSet(new int[] {_plus, _minus, _not, _tilde, _times}),
  castFollower = NewSet(new int[] {_tilde, _not, _lpar, _ident,
                 /* literals */
                 _intCon, _realCon, _charCon, _stringCon,
                 /* any keyword expect as and is */
                 _abstract, _base, _bool, _break, _byte, _case, _catch,
                 _char, _checked, _class, _const, _continue, _decimal, _default,
                 _delegate, _do, _double, _else, _enum, _event, _explicit,
                 _extern, _false, _finally, _fixed, _float, _for, _foreach,
                 _goto, _if, _implicit, _in, _int, _interface, _internal,
                 _lock, _long, _namespace, _new, _null, _object, _operator,
                 _outKW, _override, _params, _private, _protected, _public,
                 _readonly, _ref, _return, _sbyte, _sealed, _short, _sizeof,
                 _stackalloc, _static, _string, _struct, _switch, _this, _throw,
                 _true, _try, _typeof, _uint, _ulong, _unchecked, _unsafe,
                 _ushort, _usingKW, _virtual, _void, _volatile, _while
                 }),
  typArgLstFol = NewSet(new int[] {_lpar, _rpar, _rbrack, _colon, _scolon, _comma, _dot,
                 _question, _eq, _neq, _gt, _nullCoal, _lt, _lteq, _gteq, _is, _as, _andand}),
  keyword      = NewSet(new int[] {_abstract, _as, _base, _bool, _break, _byte, _case, _catch,
                 _char, _checked, _class, _const, _continue, _decimal, _default,
                 _delegate, _do, _double, _else, _enum, _event, _explicit,
                 _extern, _false, _finally, _fixed, _float, _for, _foreach,
                 _goto, _if, _implicit, _in, _int, _interface, _internal,
                 _is, _lock, _long, _namespace, _new, _null, _object, _operator,
                 _outKW, _override, _params, _private, _protected, _public,
                 _readonly, _ref, _return, _sbyte, _sealed, _short, _sizeof,
                 _stackalloc, _static, _string, _struct, _switch, _this, _throw,
                 _true, _try, _typeof, _uint, _ulong, _unchecked, _unsafe,
                 _ushort, _usingKW, _virtual, _void, _volatile, _while}),
  assgnOps     = NewSet(new int[] {_assgn, _plusassgn, _minusassgn, _timesassgn, _divassgn,
                 _modassgn, _andassgn, _orassgn, _xorassgn, _lshassgn}) /* rshassgn: ">" ">="  no whitespace allowed*/,
                 
  firstExpr    /*
                 The first set of expressions are used to determine if a "?" symbol
                 counts as a nullable qualifier or belogns to the conditional operator.
                 This is a wild guess because there is no solution for this problem in the spec.
               */
               = NewSet(new int[] { _ident, _intCon, _realCon, _charCon, _stringCon, _base,
                 _bool, _byte, _char, _checked, _decimal, _default, _delegate, _double, _false,
                 _float, _int, _long, _new, _null, _object, _sbyte, _short, _sizeof, _string, _this,
                 _true, _typeof, _uint, _ulong, _unchecked, _ushort, _and, _dec, _inc, _lpar, _minus,
                 _not, _plus, _tilde, _times })
                 ;

/*---------------------------- auxiliary methods ------------------------*/

void Error (string s) {
  if (errDist >= minErrDist) Errors.SemErr(la.line, la.col, s);
  errDist = 0;
}

// Return the n-th token after the current lookahead token
Token Peek (int n) {
  Scanner.ResetPeek();
  Token _x = la;
  while (n > 0) {
    _x = PeekWithPragmas();
    n--;
  }
  return _x;
}

Token Copy(Token t) {
    Token copy = new Token();
    copy.kind = t.kind;
    copy.pos = t.pos;
    copy.col = t.col;
    copy.line = t.line;
    copy.val = t.val;
    return copy;
}

Token CopyTokens(Token start, Token end) {
    Token tokens = Copy(start);

    Token t = tokens;
    while(true) {
       start = start.next;
       if (start == end) break;
       if (start.kind > maxT) continue;
       t = t.next = Copy(start);
    }
	return tokens;
}

// A pragmas sensitive Peek mehtod.
Token PeekWithPragmas() {
  Token _x = Scanner.PeekWithPragmas();
  while (_x.kind > maxT) {
    // Handle Pragma, this MUST stay in SYNC with the semantic actions of the pragmas!
    isScanMode = false;
    if (_x.kind == _ppDefine) {
      AddCCS(_x.val); 
    }
    else if (_x.kind == _ppUndef) {
      RemCCS(_x.val); 
    }
    else if (_x.kind == _ppIf) {
      IfPragma(_x.val); 
    }
    else if (_x.kind == _ppElif) {
      ElifOrElsePragma(); 
    }
    else if (_x.kind == _ppElse) {
      ElifOrElsePragma(); 
    }
    isScanMode = true;
    _x = Scanner.PeekWithPragmas();
  }
  return _x;
}

/* This method will be used by the pragma handlers because we
 * have to decide if the pragma works in peek mode (in a resolver)
 * or in normal scan mode (called from get while parsing).
 */
private bool isScanMode = true;
Token ScanOrPeek () {
  if (isScanMode) {
    return Scanner.Scan();
  } else {
    return Scanner.PeekWithPragmas();
  }
}

// ident "="
bool IsAssignment () {
  return kindInContext(la.kind) == _ident && Peek(1).kind == _assgn;
}

/* True, if the comma is not a trailing one, *
 * like the last one in: a, b, c,            */
bool NotFinalComma () {
  int peek = Peek(1).kind;
  return la.kind == _comma && peek != _rbrace && peek != _rbrack;
}

/* Checks whether the next sequence of tokens is a qualident *
 * and returns the next token after the qualident            *
 * !!! Proceeds from current peek position !!!               */
Token IsQualident (Token pt) {
    if (kindInContext(pt.kind) == _ident) {
        pt = PeekWithPragmas();
        while (pt.kind == _dot) {
            pt = PeekWithPragmas();
            if (kindInContext(pt.kind) != _ident) return null;
            pt = PeekWithPragmas();
        }
        return pt;
    } else return null;
}

bool IsGeneric() {
  Scanner.ResetPeek();
  Token pt = la;
  pt = IsTypeArgumentList(pt);
  return pt != null && typArgLstFol[kindInContext(pt.kind)];
}

/* returns the token after the type argument list *
 * if type argument list could be recognized,     *
 * otherwise null.                                */
Token IsTypeArgumentList(Token pt) {
  if (pt.kind == _lt) {
    pt = PeekWithPragmas();
    while (true) {
      pt = IsType(pt);
      if (pt == null) {
        return null;
      }
      if (pt.kind == _gt) {
        // list recognized
        pt = PeekWithPragmas();
        break;
      } else if (pt.kind == _comma) {
        // another argument
        pt = PeekWithPragmas();
      } else {
        // error in type argument list
        return null;
      }
    }
  } else {
    return null;
  }
  return pt;
}

/* Stores if the last IsType recognized a pointer or array type. *
 * This flag does not mean anything if the last call of IsType   *
 * did not recognize a type.                                     */
bool wasPointerOrArrayType;

/* returns the token after the type               *
 * if a type could be recognized, otherwise null. */
Token IsType (Token pt) {
  wasPointerOrArrayType = false;
  if (typeKW[kindInContext(pt.kind)]) {
    pt = PeekWithPragmas();
  } else if (pt.kind == _void) {
    pt = PeekWithPragmas();
    if (pt.kind != _times) {
      return null;
    }
    wasPointerOrArrayType = true;
    pt = PeekWithPragmas();
  } else if (kindInContext(pt.kind) == _ident) {
    pt = PeekWithPragmas();
    if (pt.kind == _dblcolon || pt.kind == _dot) {
      // either namespace alias qualifier "::" or first
      // part of the qualident
      pt = PeekWithPragmas();
      pt = IsQualident(pt);
      if (pt == null) {
        return null;
      }
    } 
    if (pt.kind == _lt) {
      pt = IsTypeArgumentList(pt);
      if (pt == null) {
        return null;
      }
      if (pt.kind == _dot) {
        pt = PeekWithPragmas();
        pt = IsType(pt);
        if (pt == null) {
          return null;
        }
      }
    }
  } else {
    return null;
  }
  if (pt.kind == _question) {
    pt = PeekWithPragmas();
  }
  
  Token prePt = pt;
  pt = SkipPointerOrDims(pt);
  wasPointerOrArrayType |= prePt != pt;
  
  return pt;
}

// Type ident
// (Type can be void*)
bool IsLocalVarDecl() {
  Token pt = la;
  Scanner.ResetPeek();
  pt = IsType(pt);
  return pt != null && kindInContext(pt.kind) == _ident;
}

// "[" ("," | "]")
bool IsDims () {
  int peek = Peek(1).kind;
  return la.kind == _lbrack && (peek == _comma || peek == _rbrack);
}

// "*" | "[" ("," | "]")
bool IsPointerOrDims () {
  return la.kind == _times || IsDims();
}

/* skip: { "[" { "," } "]" | "*" }                   */
/* returns the next token after the pointer of dims  */
/* or null if not recognized                         */
/* !!! Proceeds from current peek position !!!       */
Token SkipPointerOrDims (Token pt) {
  for (;;) {
    if (pt.kind == _lbrack) {
      do pt = PeekWithPragmas();
      while (pt.kind == _comma);
      if (pt.kind != _rbrack) return null;
    } else if (pt.kind != _times) break;
    pt = PeekWithPragmas();
  }
  return pt;
}

// Is attribute target specifier
// (ident | keyword) ":"
bool IsAttrTargSpec () {
  return (kindInContext(la.kind) == _ident || keyword[kindInContext(la.kind)]) && Peek(1).kind == _colon;
}

// ident ("," | "=" | ";")
bool IsFieldDecl () {
  int peek = Peek(1).kind;
  return kindInContext(la.kind) == _ident && 
         (peek == _comma || peek == _assgn || peek == _scolon);
}

bool IsTypeCast () {
  if (la.kind != _lpar) return false;
  if (IsSimpleTypeCast()) return true;
  return GuessTypeCast();
}

// "(" typeKW ")"
bool IsSimpleTypeCast () {
    // assert: la.kind == _lpar
    Scanner.ResetPeek();
    Token pt1 = PeekWithPragmas();
    Token pt2 = PeekWithPragmas();
    return typeKW[kindInContext(pt1.kind)] &&
            (pt2.kind == _rpar ||
            (pt2.kind == _question && PeekWithPragmas().kind == _rpar));
}

// "(" Type ")" castFollower
bool GuessTypeCast () {
  // assert: la.kind == _lpar
  Token pt = Peek(1);
  pt = IsType(pt);
  if (pt == null) {
    return false;
  }
  if (pt.kind != _rpar) {
    return false;
  }
  pt = PeekWithPragmas();
  return castFollower[kindInContext(pt.kind)] ||
        /* & for unsafe context */
        (wasPointerOrArrayType && pt.kind == _and);
}

// "[" "assembly"
bool IsGlobalAttrTarget () {
  Token pt = Peek(1);
  return la.kind == _lbrack && kindInContext(pt.kind) == _ident && (pt.val.Equals("assembly") || pt.val.Equals("module"));
}

// "extern" "alias"
// where alias is an identifier, no keyword
bool IsExternAliasDirective () {
  return la.kind == _extern && Peek(1).val.Equals("alias");
}

// true: anyToken"<"
// no whitespace between the token and the "<" allowed
// anything else will return false.
bool IsLtNoWs() {
  return (la.kind == _lt) && ((t.pos + t.val.Length) == la.pos);
}

bool IsNoSwitchLabelOrRBrace() {
  return (la.kind != _case && la.kind != _default && la.kind != _rbrace) ||
         (la.kind == _default && Peek(1).kind != _colon);
}

bool IsShift() {
  Token pt = Peek(1);
  return (la.kind == _ltlt) ||
         ( la.kind == _gt &&
           pt.kind == _gt &&
           (la.pos + la.val.Length == pt.pos)
         );
}

bool IsTypeDeclaration() {
  if (typeDeclStart[kindInContext(la.kind)]) {
    return true;
  }
  Token pt = Peek(1);
  return kindInContext(la.kind) == _ident && "partial".Equals(la.val) && typeDeclStart[kindInContext(pt.kind)];
}

// true: TypeArgumentList followed by anything but "("
bool IsPartOfMemberName() {
  Scanner.ResetPeek();
  Token pt = la;
  pt = IsTypeArgumentList(pt);
  return pt != null && pt.kind != _lpar;
}

bool IsImplicitTypedLambdaExpression() {
  Token pt = Peek(1);
  if (kindInContext(la.kind) == _ident && pt.kind == _arrow) {
    // x => 
    return true;
  }
  if (la.kind != _lpar || kindInContext(pt.kind) != _ident) {
    // no start of implicit typed lambda expression
    return false;
  }
  pt = PeekWithPragmas();
  // (x  ,    y, z) =>
  while (pt.kind == _comma) {
    pt = PeekWithPragmas();
    if (kindInContext(pt.kind) != _ident) {
      // after a comma there must be an ident
      return false;
    }
    pt = PeekWithPragmas();
  }
  return pt.kind == _rpar && PeekWithPragmas().kind == _arrow;
}

bool IsExplicitTypedLambdaExpression() {
  if (la.kind != _lpar) {
    return false;
  }
  // (
  Token pt = Peek(0);
  int nPars = 1;
  // skip explicitly typed lambda parameterlist sloppy
  while (nPars > 0) {
    pt = PeekWithPragmas();
    if (pt.kind == _EOF) break;
    if (pt.kind == _lpar) { ++nPars; }
    else if (pt.kind == _rpar) { --nPars; }
  }
  // ( formal parameters )
  // check for "=>"
  return PeekWithPragmas().kind == _arrow;
}

bool IsYieldReturn() {
  if (la.kind != _ident) {
    return false;
  }
  Token pt = Peek(1);
  return pt.kind == _return || pt.kind == _break;
}

// TypeKind
enum TypeKind {simple, array, pointer, @void}

// Operator
const int
  plusOp   = 0x00000001, minusOp  = 0x00000002, notOp    = 0x00000004, tildeOp  = 0x00000008,
  incOp    = 0x00000010, decOp    = 0x00000020, trueOp   = 0x00000040, falseOp  = 0x00000080,
  timesOp  = 0x00000100, divOp    = 0x00000200, modOp    = 0x00000400, andOp    = 0x00000800,
  orOp     = 0x00001000, xorOp    = 0x00002000, lshiftOp = 0x00004000, rshiftOp = 0x00008000,
  eqOp     = 0x00010000, neqOp    = 0x00020000, gtOp     = 0x00040000, ltOp     = 0x00080000,
  gteOp    = 0x00100000, lteOp    = 0x00200000,
  unaryOp  = plusOp|minusOp|notOp|tildeOp|incOp|decOp|trueOp|falseOp,
  binaryOp = plusOp|minusOp|timesOp|divOp|modOp|andOp|orOp|xorOp|lshiftOp|rshiftOp|eqOp|neqOp|gtOp|ltOp|gteOp|lteOp;

/*------------------------- modifier handling -----------------------------*/

// Modifier
private const long
  newMod      = 0x0001, publicMod = 0x0002, protectedMod= 0x0004, internalMod = 0x0008,
  privateMod  = 0x0010, unsafeMod = 0x0020, staticMod   = 0x0040, readonlyMod = 0x0080,
  volatileMod = 0x0100, virtualMod= 0x0200, sealedMod   = 0x0400, overrideMod = 0x0800,
  abstractMod = 0x1000, externMod = 0x2000,

  /* sets of modifiers that can be attached to certain program elements    *
   * e.g., "constants" marks all modifiers that may be used with constants */
  noneMod             = 0x0000,
  classesMod          = newMod|publicMod|protectedMod|internalMod|privateMod|unsafeMod|abstractMod|sealedMod|staticMod,
  constantsMod        = newMod|publicMod|protectedMod|internalMod|privateMod,
  fieldsMod           = newMod|publicMod|protectedMod|internalMod|privateMod|unsafeMod|staticMod|readonlyMod|volatileMod,
  propEvntMethsMod    = newMod|publicMod|protectedMod|internalMod|privateMod|unsafeMod|staticMod|virtualMod|sealedMod|overrideMod|abstractMod|externMod,
  accessorsPossib1Mod = privateMod,
  accessorsPossib2Mod = protectedMod|internalMod,
  indexersMod         = newMod|publicMod|protectedMod|internalMod|privateMod|unsafeMod|virtualMod|sealedMod|overrideMod|abstractMod|externMod,
  operatorsMod        = publicMod|unsafeMod|staticMod|externMod,
  operatorsMustMod    = publicMod|staticMod,
  constructorsMod     = publicMod|protectedMod|internalMod|privateMod|unsafeMod|externMod,
  staticConstrMod     = externMod|staticMod,
  staticConstrMustMod = staticMod,
  nonClassTypesMod    = newMod|publicMod|protectedMod|internalMod|privateMod|unsafeMod,
  destructorsMod      = externMod|unsafeMod,
  allMod              = 0x3fff;

private class Modifiers {
  private long cur = noneMod;
  private Parser parser;

  public Modifiers(Parser parser) {
    this.parser = parser;
  }

  public void Add (long m) {
    if ((cur & m) == 0) cur |= m;
    else parser.Error("modifier " + m + " already defined");
  }

  public void Add (Modifiers m) { Add(m.cur); }

  public bool IsNone() { return cur == noneMod; }

  public void Check (long allowed) {
    long wrong = cur & (allowed ^ allMod);
    if (wrong != noneMod)
      parser.Error("modifier(s) " + wrong + " not allowed here");
  }

  public void Check (long allowEither, long allowOr) {
    long wrong = cur & ((allowEither|allowOr) ^ allMod);
    if ((allowEither&allowOr) != noneMod) {
      parser.Error("modifiers providerd must not overlap");
    } else if (wrong != noneMod) {
      parser.Error("modifier(s) " + wrong + " not allowed here");
    } else if (((cur&allowEither) != noneMod) && ((cur&allowOr) != noneMod)) {
      parser.Error("modifier(s) may either be " + allowEither + " or " + allowOr);
    }
  }

  public void CheckMust (long mustHave) {
    long missing = (cur&mustHave)^mustHave;
    if (missing != noneMod) {
      parser.Error("modifier(s) " + missing + " must be applied here");
    }
  }

  public bool Has (long mod) {
    return (cur&mod) == mod;
  }
}

// LINQ Context switch

Hashtable litInOtherContext = new Hashtable();

// will be used to restore the special context kind.
int lastKind;

// contextDepth stores the recursion depth of the context, if we are in the context
// the value is > 0, outside it is 0
int contextDepth = 0;


void fillContextLitMap() {
    litInOtherContext[_from] = _ident;
    litInOtherContext[_where] = _ident;
    litInOtherContext[_join] = _ident;
    litInOtherContext[_on] = _ident;
    litInOtherContext[_equals] = _ident;
    litInOtherContext[_into] = _ident;
    litInOtherContext[_let] = _ident;
    litInOtherContext[_orderby] = _ident;
    litInOtherContext[_ascending] = _ident;
    litInOtherContext[_descending] = _ident;
    litInOtherContext[_select] = _ident;
    litInOtherContext[_group] = _ident;
    litInOtherContext[_by] = _ident;
}


int kindInContext(int kind) {
    if (contextDepth == 0) {
        // subtract extra literals from the special context as we are in normal context
        if (litInOtherContext.Contains(kind)) {
            return (int) litInOtherContext[kind];
        }
    }
    return kind;
}

void switchTokenContext() {
    // save the original kind of the token in case we have to restore it
    lastKind = la.kind;
    la.kind = kindInContext(la.kind);
}

void leaveContext() {
    // assert: contextDepth > 0;
    --contextDepth;
    if (contextDepth == 0) {
        switchTokenContext();
    }
}

void enterContext() {
    ++contextDepth;
}

void checkForContextSwitch() {
    if (contextDepth > 0) {
        // nothing to do, we are already in context.
        return;
    }
    // check for context switch
    if (lastKind ==  _from && 
        (Peek(1).kind == _ident || IsType(Peek(1)) != null) && 
        Peek(2).kind != _scolon && Peek(2).kind != _comma && 
        Peek(2).kind != _eq)    {
        // restore la token if we need a token switch
        la.kind = lastKind;
    }
}

Stack tryResults = new Stack();

/*------------------------------------------------------------------------*
 *----- SCANNER DESCRIPTION ----------------------------------------------*
 *------------------------------------------------------------------------*/



  public Parser(Scanner scanner) 
  {
    Scanner = scanner;
    OnInit();
  }

  partial void OnInit();
  partial void OnSyntaxError(int line, int col, int n);
  partial void OnSemanticError(int line, int col, string msg);
  partial void SwitchTokenContext();

  void SynErr(int n) 
  {
    if (errDist >= minErrDist)            
    {
      Errors.SynErr(la.line, la.col, n);
      OnSyntaxError(la.line, la.col, n);
    }

    errDist = 0;
  }

  public void SemErr(string msg) 
  {
    if (errDist >= minErrDist) 
    {
      Errors.SemErr(t.line, t.col, msg);
      OnSemanticError(t.line, t.col, msg);
    }

    errDist = 0;
  }
  
  void Get() 
  {
    while(true)
    {
      t = la;
      la = Scanner.Scan();
      if (la.kind <= maxT) 
      { 
        SwitchTokenContext(); 
        ++errDist; 
        break; 
      }
				if (la.kind == 147) {
				AddCCS(la.val); 
				}
				if (la.kind == 148) {
				RemCCS(la.val); 
				}
				if (la.kind == 149) {
				IfPragma(la.val); 
				}
				if (la.kind == 150) {
				ElifOrElsePragma(); 
				}
				if (la.kind == 151) {
				ElifOrElsePragma(); 
				}
				if (la.kind == 152) {
				}
				if (la.kind == 153) {
				}
				if (la.kind == 154) {
				}
				if (la.kind == 155) {
				}
				if (la.kind == 156) {
				}
				if (la.kind == 157) {
				}
				if (la.kind == 158) {
				}

      la = t;
    }
  }
  
  void Expect(int n) 
  {
    if (la.kind == n) 
      Get(); 
    else 
      SynErr(n); 
  }
  
  bool StartOf(int s) 
  {
    return set[s, la.kind];
  }
  
  void ExpectWeak(int n, int follow) 
  {
    if (la.kind == n) 
      Get();
    else 
    {
      SynErr(n);
      while (!StartOf(follow)) 
        Get();
    }
  }

  bool WeakSeparator(int n, int syFol, int repFol) 
  {
    int kind = la.kind;
    if (kind == n) 
    {
      Get(); 
      return true;
    }
    
    if (StartOf(repFol)) 
      return false;

    SynErr(n);
    while (!(set[syFol, kind] || set[repFol, kind] || set[0, kind])) 
    {
      Get();
      kind = la.kind;
    }

    return StartOf(syFol);
  }

  
	void CS3() {
		fillContextLitMap(); BeginCapture(Mode.CSharp); 
		while (IsExternAliasDirective()) {
			ExternAliasDirective();
		}
		while (la.kind == 80) {
			UsingDirective();
		}
		while (IsGlobalAttrTarget()) {
			GlobalAttributes();
		}
		while (StartOf(1)) {
			NamespaceMemberDeclaration();
		}
		Result = EndCapture(); 
	}

	void ExternAliasDirective() {
		Expect(30);
		Expect(1);
		if (!t.val.Equals("alias")) {
		 Error("alias expected");
		}
		
		Expect(1);
		Expect(118);
	}

	void UsingDirective() {
		Expect(80);
		if (IsAssignment()) {
			Expect(1);
			Expect(88);
		}
		TypeName();
		Expect(118);
	}

	void GlobalAttributes() {
		Expect(100);
		Expect(1);
		if (!t.val.Equals("assembly") && !t.val.Equals("module")) Error("global attribute target specifier \"assembly\" or \"module\" expected");
		
		Expect(89);
		Attribute();
		while (NotFinalComma()) {
			Expect(90);
			Attribute();
		}
		if (la.kind == 90) {
			Get();
		}
		Expect(116);
	}

	void NamespaceMemberDeclaration() {
		Modifiers m = new Modifiers(this); 
		if (la.kind == 47) {
			Get();
			Expect(1);
			while (la.kind == 93) {
				Get();
				Expect(1);
			}
			Expect(99);
			while (IsExternAliasDirective()) {
				ExternAliasDirective();
			}
			while (la.kind == 80) {
				UsingDirective();
			}
			while (StartOf(1)) {
				NamespaceMemberDeclaration();
			}
			Expect(115);
			if (la.kind == 118) {
				Get();
			}
		} else if (StartOf(2)) {
			while (la.kind == 100) {
				Attributes();
			}
			ModifierList(m);
			TypeDeclaration(m);
		} else SynErr(147);
	}

	void TypeName() {
		Expect(1);
		if (la.kind == 94) {
			Get();
			Expect(1);
		}
		if (la.kind == 103) {
			TypeArgumentList();
		}
		while (la.kind == 93) {
			Get();
			Expect(1);
			if (la.kind == 103) {
				TypeArgumentList();
			}
		}
	}

	void Attributes() {
		Expect(100);
		if (IsAttrTargSpec()) {
			if (la.kind == 1) {
				Get();
			} else if (StartOf(3)) {
				Keyword();
			} else SynErr(148);
			Expect(89);
		}
		Attribute();
		while (la.kind == _comma && Peek(1).kind != _rbrack) {
			Expect(90);
			Attribute();
		}
		if (la.kind == 90) {
			Get();
		}
		Expect(116);
	}

	void ModifierList(Modifiers m) {
		while (StartOf(4)) {
			switch (la.kind) {
			case 48: {
				Get();
				m.Add(newMod); 
				break;
			}
			case 57: {
				Get();
				m.Add(publicMod); 
				break;
			}
			case 56: {
				Get();
				m.Add(protectedMod); 
				break;
			}
			case 43: {
				Get();
				m.Add(internalMod); 
				break;
			}
			case 55: {
				Get();
				m.Add(privateMod); 
				break;
			}
			case 78: {
				Get();
				m.Add(unsafeMod); 
				break;
			}
			case 66: {
				Get();
				m.Add(staticMod); 
				break;
			}
			case 58: {
				Get();
				m.Add(readonlyMod); 
				break;
			}
			case 83: {
				Get();
				m.Add(volatileMod); 
				break;
			}
			case 81: {
				Get();
				m.Add(virtualMod); 
				break;
			}
			case 62: {
				Get();
				m.Add(sealedMod); 
				break;
			}
			case 53: {
				Get();
				m.Add(overrideMod); 
				break;
			}
			case 6: {
				Get();
				m.Add(abstractMod); 
				break;
			}
			case 30: {
				Get();
				m.Add(externMod); 
				break;
			}
			}
		}
	}

	void TypeDeclaration(Modifiers m) {
		TypeKind dummy; 
		if (StartOf(5)) {
			if (la.kind == 1) {
				Get();
				if (!"partial".Equals(t.val)) { Error("partial expected, found: " + t.val); } 
			}
			if (la.kind == 18) {
				m.Check(classesMod); 
				Get();
				Expect(1);
				if (la.kind == 103) {
					TypeParameterList();
				}
				if (la.kind == 89) {
					ClassBase();
				}
				while (la.kind == 1) {
					TypeParameterConstraintsClause();
				}
				ClassBody();
				if (la.kind == 118) {
					Get();
				}
			} else if (la.kind == 68) {
				m.Check(nonClassTypesMod); 
				Get();
				Expect(1);
				if (la.kind == 103) {
					TypeParameterList();
				}
				if (la.kind == 89) {
					Get();
					TypeName();
					while (la.kind == 90) {
						Get();
						TypeName();
					}
				}
				while (la.kind == 1) {
					TypeParameterConstraintsClause();
				}
				StructBody();
				if (la.kind == 118) {
					Get();
				}
			} else if (la.kind == 42) {
				m.Check(nonClassTypesMod); 
				Get();
				Expect(1);
				if (la.kind == 103) {
					TypeParameterList();
				}
				if (la.kind == 89) {
					Get();
					TypeName();
					while (la.kind == 90) {
						Get();
						TypeName();
					}
				}
				while (la.kind == 1) {
					TypeParameterConstraintsClause();
				}
				Expect(99);
				while (StartOf(6)) {
					InterfaceMemberDeclaration();
				}
				Expect(115);
				if (la.kind == 118) {
					Get();
				}
			} else SynErr(149);
		} else if (la.kind == 27) {
			m.Check(nonClassTypesMod); 
			Get();
			Expect(1);
			if (la.kind == 89) {
				Get();
				IntegralType();
			}
			EnumBody();
			if (la.kind == 118) {
				Get();
			}
		} else if (la.kind == 23) {
			m.Check(nonClassTypesMod); 
			Get();
			Type(out dummy, true);
			Expect(1);
			if (la.kind == 103) {
				TypeParameterList();
			}
			Expect(101);
			if (StartOf(7)) {
				FormalParameterList();
			}
			Expect(117);
			while (la.kind == 1) {
				TypeParameterConstraintsClause();
			}
			Expect(118);
		} else SynErr(150);
	}

	void TypeParameterList() {
		Expect(103);
		while (la.kind == 100) {
			Attributes();
		}
		Expect(1);
		while (la.kind == 90) {
			Get();
			while (la.kind == 100) {
				Attributes();
			}
			Expect(1);
		}
		Expect(96);
	}

	void ClassBase() {
		Expect(89);
		ClassType();
		while (la.kind == 90) {
			Get();
			TypeName();
		}
	}

	void TypeParameterConstraintsClause() {
		Expect(1);
		if (!t.val.Equals("where")) {
		 Error("type parameter constraints clause must start with: where");
		}
		
		Expect(1);
		Expect(89);
		if (StartOf(8)) {
			if (la.kind == 18) {
				Get();
			} else if (la.kind == 68) {
				Get();
			} else if (la.kind == 50) {
				Get();
			} else if (la.kind == 67) {
				Get();
			} else {
				TypeName();
			}
			while (la.kind == _comma && Peek(1).kind != _new) {
				Expect(90);
				TypeName();
			}
			if (la.kind == 90) {
				Get();
				Expect(48);
				Expect(101);
				Expect(117);
			}
		} else if (la.kind == 48) {
			Get();
			Expect(101);
			Expect(117);
		} else SynErr(151);
	}

	void ClassBody() {
		Expect(99);
		while (StartOf(9)) {
			while (la.kind == 100) {
				Attributes();
			}
			Modifiers m = new Modifiers(this); 
			ModifierList(m);
			ClassMemberDeclaration(m);
		}
		Expect(115);
	}

	void StructBody() {
		Expect(99);
		while (StartOf(10)) {
			while (la.kind == 100) {
				Attributes();
			}
			Modifiers m = new Modifiers(this); 
			ModifierList(m);
			StructMemberDeclaration(m);
		}
		Expect(115);
	}

	void InterfaceMemberDeclaration() {
		Modifiers m = new Modifiers(this);
		// every interface member is public
		m.Add(Parser.publicMod);
		TypeKind dummy;
		bool newSet = false;
		
		while (la.kind == 100) {
			Attributes();
		}
		if (la.kind == 48) {
			Get();
			m.Add(Parser.newMod); newSet = true; 
		}
		if (StartOf(11)) {
			if (la.kind == 78) {
				Get();
				m.Add(Parser.unsafeMod); 
			}
			if (la.kind == 48) {
				Get();
				if (newSet) Error("duplicate operand 'new'"); m.Add(Parser.newMod); 
			}
			Type(out dummy, true);
			if (la.kind == 1) {
				Get();
				if (la.kind == 101 || la.kind == 103) {
					if (la.kind == 103) {
						TypeParameterList();
					}
					Expect(101);
					if (StartOf(7)) {
						FormalParameterList();
					}
					Expect(117);
					while (la.kind == 1) {
						TypeParameterConstraintsClause();
					}
					Expect(118);
				} else if (la.kind == 99) {
					Get();
					InterfaceAccessors(m);
					Expect(115);
				} else SynErr(152);
			} else if (la.kind == 70) {
				Get();
				Expect(100);
				FormalParameterList();
				Expect(116);
				Expect(99);
				InterfaceAccessors(m);
				Expect(115);
			} else SynErr(153);
		} else if (la.kind == 28) {
			Get();
			Type(out dummy, false);
			Expect(1);
			Expect(118);
		} else SynErr(154);
	}

	void IntegralType() {
		switch (la.kind) {
		case 61: {
			Get();
			break;
		}
		case 13: {
			Get();
			break;
		}
		case 63: {
			Get();
			break;
		}
		case 79: {
			Get();
			break;
		}
		case 41: {
			Get();
			break;
		}
		case 75: {
			Get();
			break;
		}
		case 46: {
			Get();
			break;
		}
		case 76: {
			Get();
			break;
		}
		case 16: {
			Get();
			break;
		}
		default: SynErr(155); break;
		}
	}

	void EnumBody() {
		Expect(99);
		if (la.kind == 1 || la.kind == 100) {
			EnumMemberDeclaration();
			while (NotFinalComma()) {
				Expect(90);
				EnumMemberDeclaration();
			}
			if (la.kind == 90) {
				Get();
			}
		}
		Expect(115);
	}

	void Type(out TypeKind type, bool voidAllowed) {
		type = TypeKind.simple; 
		if (StartOf(12)) {
			PrimitiveType();
		} else if (la.kind == 1 || la.kind == 50 || la.kind == 67) {
			ClassType();
		} else if (la.kind == 82) {
			Get();
			type = TypeKind.@void; 
		} else SynErr(156);
		if (la.kind == 114) {
			Get();
			if (type == TypeKind.@void) { Error("Unexpected token ?, void must not be nullable."); } 
		}
		PointerOrArray(out type, type);
		if (type == TypeKind.@void && !voidAllowed) { Error("type expected, void found, maybe you mean void*"); } 
	}

	void FormalParameterList() {
		TypeKind type; 
		while (la.kind == 100) {
			Attributes();
		}
		if ("__arglist".Equals(la.val)) {
			Expect(1);
		} else if (StartOf(13)) {
			if (la.kind == 52 || la.kind == 59 || la.kind == 70) {
				if (la.kind == 59) {
					Get();
				} else if (la.kind == 52) {
					Get();
				} else {
					Get();
				}
			}
			Type(out type, false);
			Expect(1);
			if (la.kind == 90) {
				Get();
				FormalParameterList();
			}
		} else if (la.kind == 54) {
			Get();
			Type(out type, false);
			if (type != TypeKind.array) { Error("params argument must be an array"); } 
			Expect(1);
		} else SynErr(157);
	}

	void ClassType() {
		if (la.kind == 1) {
			TypeName();
		} else if (la.kind == 50 || la.kind == 67) {
			InternalClassType();
		} else SynErr(158);
	}

	void ClassMemberDeclaration(Modifiers m) {
		if (StartOf(14)) {
			StructMemberDeclaration(m);
		} else if (la.kind == 119) {
			Get();
			Expect(1);
			Expect(101);
			Expect(117);
			if (la.kind == 99) {
				Block();
			} else if (la.kind == 118) {
				Get();
			} else SynErr(159);
		} else SynErr(160);
	}

	void StructMemberDeclaration(Modifiers m) {
		TypeKind type; int op; 
		if (la.kind == 19) {
			m.Check(constantsMod); 
			Get();
			Type(out type, false);
			Expect(1);
			Expect(88);
			Expression();
			while (la.kind == 90) {
				Get();
				Expect(1);
				Expect(88);
				Expression();
			}
			Expect(118);
		} else if (la.kind == 28) {
			m.Check(propEvntMethsMod); 
			Get();
			Type(out type, false);
			if (IsFieldDecl()) {
				VariableDeclarators(m);
				Expect(118);
			} else if (la.kind == 1) {
				TypeName();
				Expect(99);
				EventAccessorDeclarations();
				Expect(115);
			} else SynErr(161);
		} else if (kindInContext(la.kind) == _ident && Peek(1).kind == _lpar) {
			m.Check(constructorsMod|staticConstrMod); 
			Expect(1);
			Expect(101);
			if (StartOf(7)) {
				m.Check(constructorsMod); 
				FormalParameterList();
			}
			Expect(117);
			if (la.kind == 89) {
				m.Check(constructorsMod); 
				Get();
				if (la.kind == 10) {
					Get();
				} else if (la.kind == 70) {
					Get();
				} else SynErr(162);
				Expect(101);
				if (StartOf(15)) {
					Argument();
					while (la.kind == 90) {
						Get();
						Argument();
					}
				}
				Expect(117);
			} else if (la.kind == 99 || la.kind == 118) {
			} else SynErr(163);
			if (la.kind == 99) {
				Block();
			} else if (la.kind == 118) {
				Get();
			} else SynErr(164);
		} else if (la.kind == 33) {
			Get();
			Type(out type, true);
			Expect(1);
			Expect(100);
			Expression();
			Expect(116);
			Expect(118);
		} else if (IsTypeDeclaration()) {
			TypeDeclaration(m);
		} else if (StartOf(16)) {
			if ("partial".Equals(la.val)) {
				Expect(1);
			}
			if ("async".Equals(la.val)) {
				Expect(1);
			}
			Type(out type, true);
			if (la.kind == 51) {
				m.Check(operatorsMod);
				m.CheckMust(operatorsMustMod);
				if (type == TypeKind.@void) { Error("operator not allowed on void"); } 
				
				Get();
				OverloadableOp(out op);
				Expect(101);
				Type(out type, false);
				Expect(1);
				if (la.kind == 90) {
					Get();
					Type(out type, false);
					if ((op & binaryOp) == 0) Error("too many operands for unary operator"); 
					Expect(1);
				} else if (la.kind == 117) {
					if ((op & unaryOp) == 0) Error("too few operands for binary operator"); 
				} else SynErr(165);
				Expect(117);
				if (la.kind == 99) {
					Block();
				} else if (la.kind == 118) {
					Get();
				} else SynErr(166);
			} else if (IsFieldDecl()) {
				m.Check(fieldsMod);
				if (type == TypeKind.@void) { Error("field type must not be void"); }
				
				VariableDeclarators(m);
				Expect(118);
			} else if (la.kind == 1) {
				MemberName();
				if (la.kind == 99) {
					m.Check(propEvntMethsMod);
					if (type == TypeKind.@void) { Error("property type must not be void"); }
					
					Get();
					AccessorDeclarations(m);
					Expect(115);
				} else if (la.kind == 93) {
					m.Check(indexersMod);
					if (type == TypeKind.@void) { Error("indexer type must not be void"); } 
					
					Get();
					Expect(70);
					Expect(100);
					FormalParameterList();
					Expect(116);
					Expect(99);
					AccessorDeclarations(m);
					Expect(115);
				} else if (la.kind == 101 || la.kind == 103) {
					m.Check(propEvntMethsMod); 
					if (la.kind == 103) {
						TypeParameterList();
					}
					Expect(101);
					if (StartOf(7)) {
						FormalParameterList();
					}
					Expect(117);
					while (la.kind == 1) {
						TypeParameterConstraintsClause();
					}
					if (la.kind == 99) {
						Block();
					} else if (la.kind == 118) {
						Get();
					} else SynErr(167);
				} else SynErr(168);
			} else if (la.kind == 70) {
				m.Check(indexersMod);
				if (type == TypeKind.@void) { Error("indexer type must not be void"); }
				
				Get();
				Expect(100);
				FormalParameterList();
				Expect(116);
				Expect(99);
				AccessorDeclarations(m);
				Expect(115);
			} else SynErr(169);
		} else if (la.kind == 29 || la.kind == 39) {
			m.Check(operatorsMod);
			m.CheckMust(operatorsMustMod);
			
			if (la.kind == 39) {
				Get();
			} else {
				Get();
			}
			Expect(51);
			Type(out type, false);
			if (type == TypeKind.@void) { Error("cast type must not be void"); } 
			Expect(101);
			Type(out type, false);
			Expect(1);
			Expect(117);
			if (la.kind == 99) {
				Block();
			} else if (la.kind == 118) {
				Get();
			} else SynErr(170);
		} else SynErr(171);
	}

	void EnumMemberDeclaration() {
		while (la.kind == 100) {
			Attributes();
		}
		Expect(1);
		if (la.kind == 88) {
			Get();
			Expression();
		}
	}

	void Block() {
		Expect(99);
		while (StartOf(17)) {
			Statement();
		}
		Expect(115);
	}

	void Expression() {
		checkForContextSwitch(); 
		if (la.kind == 127) {
			QueryExpression();
		} else if (la.kind == 8) {
			Get();
			Expression();
		} else if (la.kind == 103) {
			RootCsxTag();
		} else if (IsImplicitTypedLambdaExpression()) {
			ImplicitLambdaExpression();
		} else if (IsExplicitTypedLambdaExpression()) {
			Expect(101);
			if (StartOf(18)) {
				AnonymousMethodParameter();
				while (la.kind == 90) {
					Get();
					AnonymousMethodParameter();
				}
			}
			Expect(117);
			Expect(87);
			if (la.kind == 99) {
				Block();
			} else if (StartOf(19)) {
				Expression();
			} else SynErr(172);
		} else if (StartOf(20)) {
			Unary();
			if (assgnOps[kindInContext(la.kind)] || (la.kind == _gt && Peek(1).kind == _gteq)) {
				AssignmentOperator();
				Expression();
			} else if (StartOf(21)) {
				NullCoalescingExpr();
				if (la.kind == 114) {
					Get();
					Expression();
					Expect(89);
					Expression();
				}
			} else SynErr(173);
		} else SynErr(174);
	}

	void VariableDeclarators(Modifiers m) {
		Expect(1);
		if (la.kind == 88) {
			Get();
			VariableInitializer();
		}
		while (la.kind == 90) {
			Get();
			Expect(1);
			if (la.kind == 88) {
				Get();
				VariableInitializer();
			}
		}
	}

	void EventAccessorDeclarations() {
		bool addFound = false, remFound = false; 
		while (la.kind == 100) {
			Attributes();
		}
		if (la.val.Equals("add")) {
			Expect(1);
			addFound = true; 
		} else if (la.val.Equals("remove")) {
			Expect(1);
			remFound = true; 
		} else if (la.kind == 1) {
			Get();
			Error("add or remove expected"); 
		} else SynErr(175);
		Block();
		if (la.kind == 1 || la.kind == 100) {
			while (la.kind == 100) {
				Attributes();
			}
			if (la.val.Equals("add")) {
				Expect(1);
				if (addFound) Error("add already declared");
				else {
				  addFound = true; remFound = false;
				}
				
			} else if (la.val.Equals("remove")) {
				Expect(1);
				if (remFound) Error("remove already declared");
				else {
				  remFound = true; addFound = false;
				}
				
			} else if (la.kind == 1) {
				Get();
				addFound = false; remFound = false; Error("add or remove expected"); 
			} else SynErr(176);
			Block();
		}
	}

	void Argument() {
		if (la.kind == 52 || la.kind == 59) {
			if (la.kind == 59) {
				Get();
			} else {
				Get();
			}
		}
		Expression();
	}

	void OverloadableOp(out int op) {
		op = plusOp; 
		switch (la.kind) {
		case 112: {
			Get();
			break;
		}
		case 105: {
			Get();
			op = minusOp; 
			break;
		}
		case 109: {
			Get();
			op = notOp; 
			break;
		}
		case 119: {
			Get();
			op = tildeOp; 
			break;
		}
		case 98: {
			Get();
			op = incOp; 
			break;
		}
		case 91: {
			Get();
			op = decOp; 
			break;
		}
		case 72: {
			Get();
			op = trueOp; 
			break;
		}
		case 31: {
			Get();
			op = falseOp; 
			break;
		}
		case 120: {
			Get();
			op = timesOp; 
			break;
		}
		case 143: {
			Get();
			op = divOp; 
			break;
		}
		case 144: {
			Get();
			op = modOp; 
			break;
		}
		case 85: {
			Get();
			op = andOp; 
			break;
		}
		case 141: {
			Get();
			op = orOp; 
			break;
		}
		case 142: {
			Get();
			op = xorOp; 
			break;
		}
		case 104: {
			Get();
			op = lshiftOp; 
			break;
		}
		case 95: {
			Get();
			op = eqOp; 
			break;
		}
		case 108: {
			Get();
			op = neqOp; 
			break;
		}
		case 96: {
			Get();
			op = gtOp; 
			if (la.kind == 96) {
				if (la.pos > t.pos+1) Error("no whitespace allowed in right shift operator"); 
				Get();
				op = rshiftOp; 
			}
			break;
		}
		case 103: {
			Get();
			op = ltOp; 
			break;
		}
		case 97: {
			Get();
			op = gteOp; 
			break;
		}
		case 124: {
			Get();
			op = lteOp; 
			break;
		}
		default: SynErr(177); break;
		}
	}

	void MemberName() {
		Expect(1);
		if (la.kind == 94) {
			Get();
			Expect(1);
		}
		if (la.kind == _lt && IsPartOfMemberName()) {
			TypeArgumentList();
		}
		while (la.kind == _dot && kindInContext(Peek(1).kind) == _ident) {
			Expect(93);
			Expect(1);
			if (la.kind == _lt && IsPartOfMemberName()) {
				TypeArgumentList();
			}
		}
	}

	void AccessorDeclarations(Modifiers m) {
		Modifiers am = new Modifiers(this);
		bool getFound = false, setFound = false;
		
		while (la.kind == 100) {
			Attributes();
		}
		ModifierList(am);
		am.Check(accessorsPossib1Mod, accessorsPossib2Mod); 
		if (la.val.Equals("get")) {
			Expect(1);
			getFound = true; 
		} else if (la.val.Equals("set")) {
			Expect(1);
			setFound = true; 
		} else if (la.kind == 1) {
			Get();
			Error("set or get expected"); 
		} else SynErr(178);
		if (la.kind == 99) {
			Block();
		} else if (la.kind == 118) {
			Get();
		} else SynErr(179);
		if (StartOf(22)) {
			am = new Modifiers(this); 
			while (la.kind == 100) {
				Attributes();
			}
			ModifierList(am);
			am.Check(accessorsPossib1Mod, accessorsPossib2Mod); 
			if (la.val.Equals("get")) {
				Expect(1);
				if (getFound) Error("get already declared");  getFound = true; 
			} else if (la.val.Equals("set")) {
				Expect(1);
				if (setFound) Error("set already declared");  setFound = true;
			} else if (la.kind == 1) {
				Get();
				Error("set or get expected"); 
			} else SynErr(180);
			if (la.kind == 99) {
				Block();
			} else if (la.kind == 118) {
				Get();
			} else SynErr(181);
		}
	}

	void InterfaceAccessors(Modifiers m) {
		bool getFound = false, setFound = false; 
		while (la.kind == 100) {
			Attributes();
		}
		if (la.val.Equals("get")) {
			Expect(1);
			getFound = true; 
		} else if (la.val.Equals("set")) {
			Expect(1);
			setFound = true; 
		} else if (la.kind == 1) {
			Get();
			Error("set or get expected"); 
		} else SynErr(182);
		Expect(118);
		if (la.kind == 1 || la.kind == 100) {
			while (la.kind == 100) {
				Attributes();
			}
			if (la.val.Equals("get")) {
				Expect(1);
				if (getFound) Error("get already declared");  
			} else if (la.val.Equals("set")) {
				Expect(1);
				if (setFound) Error("set already declared");  
			} else if (la.kind == 1) {
				Get();
				Error("set or get expected"); 
			} else SynErr(183);
			Expect(118);
		}
	}

	void LocalVariableType() {
		TypeKind dummy; 
		Type(out dummy, false);
	}

	void LocalVariableDeclaration() {
		LocalVariableType();
		LocalVariableDeclarator();
		while (la.kind == 90) {
			Get();
			LocalVariableDeclarator();
		}
	}

	void LocalVariableDeclarator() {
		TypeKind dummy; 
		Expect(1);
		if (la.kind == 90 || la.kind == 117 || la.kind == 118) {
		} else if (la.kind == 88) {
			Get();
			if (StartOf(23)) {
				VariableInitializer();
			} else if (la.kind == 65) {
				Get();
				Type(out dummy, false);
				Expect(100);
				Expression();
				Expect(116);
			} else SynErr(184);
		} else SynErr(185);
	}

	void VariableInitializer() {
		if (StartOf(19)) {
			Expression();
		} else if (la.kind == 99) {
			ArrayInitializer();
		} else SynErr(186);
	}

	void ArrayInitializer() {
		Expect(99);
		if (StartOf(23)) {
			VariableInitializer();
			while (NotFinalComma()) {
				Expect(90);
				VariableInitializer();
			}
			if (la.kind == 90) {
				Get();
			}
		}
		Expect(115);
	}

	void Attribute() {
		TypeName();
		if (la.kind == 101) {
			AttributeArguments();
		}
	}

	void Keyword() {
		switch (la.kind) {
		case 6: {
			Get();
			break;
		}
		case 9: {
			Get();
			break;
		}
		case 7: {
			Get();
			break;
		}
		case 8: {
			Get();
			break;
		}
		case 10: {
			Get();
			break;
		}
		case 11: {
			Get();
			break;
		}
		case 12: {
			Get();
			break;
		}
		case 13: {
			Get();
			break;
		}
		case 14: {
			Get();
			break;
		}
		case 15: {
			Get();
			break;
		}
		case 16: {
			Get();
			break;
		}
		case 17: {
			Get();
			break;
		}
		case 18: {
			Get();
			break;
		}
		case 19: {
			Get();
			break;
		}
		case 20: {
			Get();
			break;
		}
		case 21: {
			Get();
			break;
		}
		case 22: {
			Get();
			break;
		}
		case 23: {
			Get();
			break;
		}
		case 24: {
			Get();
			break;
		}
		case 25: {
			Get();
			break;
		}
		case 26: {
			Get();
			break;
		}
		case 27: {
			Get();
			break;
		}
		case 28: {
			Get();
			break;
		}
		case 29: {
			Get();
			break;
		}
		case 30: {
			Get();
			break;
		}
		case 31: {
			Get();
			break;
		}
		case 32: {
			Get();
			break;
		}
		case 33: {
			Get();
			break;
		}
		case 34: {
			Get();
			break;
		}
		case 35: {
			Get();
			break;
		}
		case 36: {
			Get();
			break;
		}
		case 37: {
			Get();
			break;
		}
		case 38: {
			Get();
			break;
		}
		case 39: {
			Get();
			break;
		}
		case 40: {
			Get();
			break;
		}
		case 41: {
			Get();
			break;
		}
		case 42: {
			Get();
			break;
		}
		case 43: {
			Get();
			break;
		}
		case 44: {
			Get();
			break;
		}
		case 45: {
			Get();
			break;
		}
		case 46: {
			Get();
			break;
		}
		case 47: {
			Get();
			break;
		}
		case 48: {
			Get();
			break;
		}
		case 49: {
			Get();
			break;
		}
		case 50: {
			Get();
			break;
		}
		case 51: {
			Get();
			break;
		}
		case 52: {
			Get();
			break;
		}
		case 53: {
			Get();
			break;
		}
		case 54: {
			Get();
			break;
		}
		case 55: {
			Get();
			break;
		}
		case 56: {
			Get();
			break;
		}
		case 57: {
			Get();
			break;
		}
		case 58: {
			Get();
			break;
		}
		case 59: {
			Get();
			break;
		}
		case 60: {
			Get();
			break;
		}
		case 61: {
			Get();
			break;
		}
		case 62: {
			Get();
			break;
		}
		case 63: {
			Get();
			break;
		}
		case 64: {
			Get();
			break;
		}
		case 65: {
			Get();
			break;
		}
		case 66: {
			Get();
			break;
		}
		case 67: {
			Get();
			break;
		}
		case 68: {
			Get();
			break;
		}
		case 69: {
			Get();
			break;
		}
		case 70: {
			Get();
			break;
		}
		case 71: {
			Get();
			break;
		}
		case 72: {
			Get();
			break;
		}
		case 73: {
			Get();
			break;
		}
		case 74: {
			Get();
			break;
		}
		case 75: {
			Get();
			break;
		}
		case 76: {
			Get();
			break;
		}
		case 77: {
			Get();
			break;
		}
		case 78: {
			Get();
			break;
		}
		case 79: {
			Get();
			break;
		}
		case 80: {
			Get();
			break;
		}
		case 81: {
			Get();
			break;
		}
		case 82: {
			Get();
			break;
		}
		case 83: {
			Get();
			break;
		}
		case 84: {
			Get();
			break;
		}
		default: SynErr(187); break;
		}
	}

	void AttributeArguments() {
		bool nameFound = false; 
		Expect(101);
		if (StartOf(19)) {
			if (IsAssignment()) {
				nameFound = true; 
				Expect(1);
				Expect(88);
			}
			Expression();
			while (la.kind == 90) {
				Get();
				if (IsAssignment()) {
					nameFound = true; 
					Expect(1);
					Expect(88);
				} else if (StartOf(19)) {
					if (nameFound) Error("no positional argument after named arguments"); 
				} else SynErr(188);
				Expression();
			}
		}
		Expect(117);
	}

	void PrimitiveType() {
		if (StartOf(24)) {
			IntegralType();
		} else if (la.kind == 34) {
			Get();
		} else if (la.kind == 25) {
			Get();
		} else if (la.kind == 21) {
			Get();
		} else if (la.kind == 11) {
			Get();
		} else SynErr(189);
	}

	void PointerOrArray(out TypeKind type, TypeKind curType) {
		type = curType; int dims = 0; 
		while (IsPointerOrDims()) {
			if (la.kind == 120) {
				Get();
				type = TypeKind.pointer; 
			} else if (la.kind == 100) {
				Get();
				dims = 1; type = TypeKind.array; 
				while (la.kind == 90) {
					Get();
					dims++; 
				}
				Expect(116);
			} else SynErr(190);
		}
	}

	void ResolvedType() {
		TypeKind type = TypeKind.simple; 
		if (StartOf(12)) {
			PrimitiveType();
		} else if (la.kind == 50) {
			Get();
		} else if (la.kind == 67) {
			Get();
		} else if (la.kind == 1) {
			Get();
			if (la.kind == 94) {
				Get();
				Expect(1);
			}
			if (IsGeneric()) {
				TypeArgumentList();
			}
			while (la.kind == 93) {
				Get();
				Expect(1);
				if (IsGeneric()) {
					TypeArgumentList();
				}
			}
		} else if (la.kind == 82) {
			Get();
			type = TypeKind.@void; 
		} else SynErr(191);
		if (la.kind == _question &&
!firstExpr[kindInContext(Peek(1).kind)]) {
			Expect(114);
			if (type == TypeKind.@void) { Error("Unexpected token ?, void must not be nullable."); } 
		}
		PointerOrArray(out type, type);
		if (type == TypeKind.@void) Error("type expected, void found, maybe you mean void*"); 
	}

	void TypeArgumentList() {
		TypeKind dummy; 
		Expect(103);
		if (StartOf(16)) {
			Type(out dummy, false);
		} else if (la.kind == 90 || la.kind == 96) {
		} else SynErr(192);
		while (la.kind == 90) {
			Get();
			if (StartOf(16)) {
				Type(out dummy, false);
			} else if (la.kind == 90 || la.kind == 96) {
			} else SynErr(193);
		}
		Expect(96);
	}

	void InternalClassType() {
		if (la.kind == 50) {
			Get();
		} else if (la.kind == 67) {
			Get();
		} else SynErr(194);
	}

	void Statement() {
		TypeKind dummy; 
		if (kindInContext(la.kind) == _ident && Peek(1).kind == _colon) {
			Expect(1);
			Expect(89);
			Statement();
		} else if (la.kind == 19) {
			Get();
			Type(out dummy, false);
			Expect(1);
			Expect(88);
			Expression();
			while (la.kind == 90) {
				Get();
				Expect(1);
				Expect(88);
				Expression();
			}
			Expect(118);
		} else if (la.kind == _void || IsLocalVarDecl()) {
			LocalVariableDeclaration();
			Expect(118);
		} else if (StartOf(25)) {
			EmbeddedStatement();
		} else SynErr(195);
	}

	void EmbeddedStatement() {
		TypeKind type;
		if (la.kind == 99) {
			Block();
		} else if (la.kind == 118) {
			Get();
		} else if (la.kind == _checked && Peek(1).kind == _lbrace) {
			Expect(17);
			Block();
		} else if (la.kind == _unchecked && Peek(1).kind == _lbrace) {
			Expect(77);
			Block();
		} else if (IsYieldReturn()) {
			Expect(1);
			if (la.kind == 60) {
				Get();
				Expression();
			} else if (la.kind == 12) {
				Get();
			} else SynErr(196);
			Expect(118);
		} else if (StartOf(20)) {
			StatementExpression();
			Expect(118);
		} else if (la.kind == 38) {
			Get();
			Expect(101);
			Expression();
			Expect(117);
			EmbeddedStatement();
			if (la.kind == 26) {
				Get();
				EmbeddedStatement();
			}
		} else if (la.kind == 69) {
			Get();
			Expect(101);
			Expression();
			Expect(117);
			Expect(99);
			while (la.kind == 14 || la.kind == 22) {
				SwitchSection();
			}
			Expect(115);
		} else if (la.kind == 84) {
			Get();
			Expect(101);
			Expression();
			Expect(117);
			EmbeddedStatement();
		} else if (la.kind == 24) {
			Get();
			EmbeddedStatement();
			Expect(84);
			Expect(101);
			Expression();
			Expect(117);
			Expect(118);
		} else if (la.kind == 35) {
			Get();
			Expect(101);
			if (StartOf(26)) {
				ForInitializer();
			}
			Expect(118);
			if (StartOf(19)) {
				Expression();
			}
			Expect(118);
			if (StartOf(20)) {
				ForIterator();
			}
			Expect(117);
			EmbeddedStatement();
		} else if (la.kind == 36) {
			Get();
			Expect(101);
			LocalVariableType();
			Expect(1);
			Expect(40);
			Expression();
			Expect(117);
			EmbeddedStatement();
		} else if (la.kind == 12) {
			Get();
			Expect(118);
		} else if (la.kind == 20) {
			Get();
			Expect(118);
		} else if (la.kind == 37) {
			Get();
			if (la.kind == 1) {
				Get();
			} else if (la.kind == 14) {
				Get();
				Expression();
			} else if (la.kind == 22) {
				Get();
			} else SynErr(197);
			Expect(118);
		} else if (la.kind == 60) {
			Get();
			if (StartOf(19)) {
				Expression();
			}
			Expect(118);
		} else if (la.kind == 71) {
			Get();
			if (StartOf(19)) {
				Expression();
			}
			Expect(118);
		} else if (la.kind == 73) {
			Get();
			Block();
			if (la.kind == 15) {
				CatchClauses();
				if (la.kind == 32) {
					Get();
					Block();
				}
			} else if (la.kind == 32) {
				Get();
				Block();
			} else SynErr(198);
		} else if (la.kind == 45) {
			Get();
			Expect(101);
			Expression();
			Expect(117);
			EmbeddedStatement();
		} else if (la.kind == 80) {
			Get();
			Expect(101);
			ResourceAcquisition();
			Expect(117);
			EmbeddedStatement();
		} else if (la.kind == 78) {
			Get();
			Block();
		} else if (la.kind == 33) {
			Get();
			Expect(101);
			Type(out type, false);
			if (type != TypeKind.pointer) Error("can only fix pointer types"); 
			Expect(1);
			Expect(88);
			Expression();
			while (la.kind == 90) {
				Get();
				Expect(1);
				Expect(88);
				Expression();
			}
			Expect(117);
			EmbeddedStatement();
		} else SynErr(199);
	}

	void StatementExpression() {
		bool isAssignment = assnStartOp[kindInContext(la.kind)] || IsTypeCast(); 
		Unary();
		if (StartOf(27)) {
			AssignmentOperator();
			Expression();
		} else if (la.kind == 90 || la.kind == 117 || la.kind == 118) {
			if (isAssignment) Error("error in assignment."); 
		} else SynErr(200);
	}

	void SwitchSection() {
		SwitchLabel();
		while (la.kind == _case || (la.kind == _default && Peek(1).kind == _colon)) {
			SwitchLabel();
		}
		Statement();
		while (IsNoSwitchLabelOrRBrace()) {
			Statement();
		}
	}

	void ForInitializer() {
		if (IsLocalVarDecl()) {
			LocalVariableDeclaration();
		} else if (StartOf(20)) {
			StatementExpression();
			while (la.kind == 90) {
				Get();
				StatementExpression();
			}
		} else SynErr(201);
	}

	void ForIterator() {
		StatementExpression();
		while (la.kind == 90) {
			Get();
			StatementExpression();
		}
	}

	void CatchClauses() {
		Expect(15);
		if (la.kind == 99) {
			Block();
		} else if (la.kind == 101) {
			Get();
			ClassType();
			if (la.kind == 1) {
				Get();
			}
			Expect(117);
			Block();
			if (la.kind == 15) {
				CatchClauses();
			}
		} else SynErr(202);
	}

	void ResourceAcquisition() {
		if (IsLocalVarDecl()) {
			LocalVariableDeclaration();
		} else if (StartOf(19)) {
			Expression();
		} else SynErr(203);
	}

	void Unary() {
		TypeKind dummy; 
		while (unaryHead[la.kind] || IsTypeCast()) {
			switch (la.kind) {
			case 112: {
				Get();
				break;
			}
			case 105: {
				Get();
				break;
			}
			case 109: {
				Get();
				break;
			}
			case 119: {
				Get();
				break;
			}
			case 98: {
				Get();
				break;
			}
			case 91: {
				Get();
				break;
			}
			case 120: {
				Get();
				break;
			}
			case 85: {
				Get();
				break;
			}
			case 101: {
				Get();
				Type(out dummy, false);
				Expect(117);
				break;
			}
			default: SynErr(204); break;
			}
		}
		Primary();
	}

	void AssignmentOperator() {
		switch (la.kind) {
		case 88: {
			Get();
			break;
		}
		case 113: {
			Get();
			break;
		}
		case 106: {
			Get();
			break;
		}
		case 121: {
			Get();
			break;
		}
		case 92: {
			Get();
			break;
		}
		case 107: {
			Get();
			break;
		}
		case 86: {
			Get();
			break;
		}
		case 111: {
			Get();
			break;
		}
		case 122: {
			Get();
			break;
		}
		case 102: {
			Get();
			break;
		}
		case 96: {
			Get();
			int pos = t.pos; 
			Expect(97);
			if (pos+1 < t.pos) Error("no whitespace allowed in right shift assignment"); 
			break;
		}
		default: SynErr(205); break;
		}
	}

	void SwitchLabel() {
		if (la.kind == 14) {
			Get();
			Expression();
			Expect(89);
		} else if (la.kind == 22) {
			Get();
			Expect(89);
		} else SynErr(206);
	}

	void QueryExpression() {
		enterContext(); 
		FromClause();
		QueryBody();
		leaveContext(); 
	}

	void RootCsxTag() {
		BeginCapture(Mode.Csx); PElement root; 
		var indent = la.col;                      
		CsxTag(out root);
		EndCapture(); Out(root, indent);         
	}

	void ImplicitLambdaExpression() {
		if (la.kind == 1) {
			ImplicitAnonymousFunctionParameter();
		} else if (la.kind == 101) {
			Get();
			if (la.kind == 1) {
				ImplicitAnonymousFunctionParameter();
				while (la.kind == 90) {
					Get();
					ImplicitAnonymousFunctionParameter();
				}
			}
			Expect(117);
		} else SynErr(207);
		Expect(87);
		ImplicitTypedLambdaBody();
	}

	void AnonymousMethodParameter() {
		TypeKind dummy; 
		if (la.kind == 52 || la.kind == 59) {
			if (la.kind == 59) {
				Get();
			} else {
				Get();
			}
		}
		Type(out dummy, false);
		Expect(1);
	}

	void NullCoalescingExpr() {
		OrExpr();
		while (la.kind == 110) {
			Get();
			Unary();
			OrExpr();
		}
	}

	void OrExpr() {
		AndExpr();
		while (la.kind == 140) {
			Get();
			Unary();
			AndExpr();
		}
	}

	void AndExpr() {
		BitOrExpr();
		while (la.kind == 123) {
			Get();
			Unary();
			BitOrExpr();
		}
	}

	void BitOrExpr() {
		BitXorExpr();
		while (la.kind == 141) {
			Get();
			Unary();
			BitXorExpr();
		}
	}

	void BitXorExpr() {
		BitAndExpr();
		while (la.kind == 142) {
			Get();
			Unary();
			BitAndExpr();
		}
	}

	void BitAndExpr() {
		EqlExpr();
		while (la.kind == 85) {
			Get();
			Unary();
			EqlExpr();
		}
	}

	void EqlExpr() {
		RelExpr();
		while (la.kind == 95 || la.kind == 108) {
			if (la.kind == 108) {
				Get();
			} else {
				Get();
			}
			Unary();
			RelExpr();
		}
	}

	void RelExpr() {
		ShiftExpr();
		while (StartOf(28)) {
			if (StartOf(29)) {
				if (la.kind == 103) {
					Get();
				} else if (la.kind == 96) {
					Get();
				} else if (la.kind == 124) {
					Get();
				} else {
					Get();
				}
				Unary();
				ShiftExpr();
			} else {
				if (la.kind == 44) {
					Get();
				} else {
					Get();
				}
				ResolvedType();
			}
		}
	}

	void ShiftExpr() {
		AddExpr();
		while (IsShift()) {
			if (la.kind == 104) {
				Get();
			} else if (la.kind == 96) {
				Get();
				Expect(96);
			} else SynErr(208);
			Unary();
			AddExpr();
		}
	}

	void AddExpr() {
		MulExpr();
		while (la.kind == 105 || la.kind == 112) {
			if (la.kind == 112) {
				Get();
			} else {
				Get();
			}
			Unary();
			MulExpr();
		}
	}

	void MulExpr() {
		while (la.kind == 120 || la.kind == 143 || la.kind == 144) {
			if (la.kind == 120) {
				Get();
			} else if (la.kind == 143) {
				Get();
			} else {
				Get();
			}
			Unary();
		}
	}

	void Primary() {
		TypeKind type; bool isArrayCreation = false; 
		switch (la.kind) {
		case 2: case 3: case 4: case 5: case 31: case 49: case 72: {
			Literal();
			break;
		}
		case 101: {
			Get();
			Expression();
			Expect(117);
			break;
		}
		case 11: case 13: case 16: case 21: case 25: case 34: case 41: case 46: case 50: case 61: case 63: case 67: case 75: case 76: case 79: {
			switch (la.kind) {
			case 11: {
				Get();
				break;
			}
			case 13: {
				Get();
				break;
			}
			case 16: {
				Get();
				break;
			}
			case 21: {
				Get();
				break;
			}
			case 25: {
				Get();
				break;
			}
			case 34: {
				Get();
				break;
			}
			case 41: {
				Get();
				break;
			}
			case 46: {
				Get();
				break;
			}
			case 50: {
				Get();
				break;
			}
			case 61: {
				Get();
				break;
			}
			case 63: {
				Get();
				break;
			}
			case 67: {
				Get();
				break;
			}
			case 75: {
				Get();
				break;
			}
			case 76: {
				Get();
				break;
			}
			case 79: {
				Get();
				break;
			}
			}
			if (la.kind == 93) {
				Get();
				Expect(1);
				if (IsGeneric()) {
					TypeArgumentList();
				}
			}
			break;
		}
		case 1: {
			Get();
			if (la.kind == 94) {
				Get();
				Expect(1);
				if (la.kind == 103) {
					TypeArgumentList();
				}
				Expect(93);
				Expect(1);
			}
			if (IsGeneric()) {
				TypeArgumentList();
			}
			break;
		}
		case 70: {
			Get();
			break;
		}
		case 10: {
			Get();
			break;
		}
		case 48: {
			Get();
			if (StartOf(16)) {
				Type(out type, false);
				if (la.kind == 101) {
					Get();
					if (StartOf(15)) {
						Argument();
						while (la.kind == 90) {
							Get();
							Argument();
						}
					}
					Expect(117);
					if (la.kind == 99) {
						ObjectOrCollectionInitializer();
					}
				} else if (la.kind == _lbrace && type != TypeKind.array) {
					ObjectOrCollectionInitializer();
				} else if (la.kind == 100) {
					int dims = 1; 
					Get();
					Expression();
					while (la.kind == 90) {
						Get();
						Expression();
						++dims; 
					}
					Expect(116);
					while (IsDims()) {
						Expect(100);
						dims = 1; 
						while (la.kind == 90) {
							Get();
							++dims; 
						}
						Expect(116);
					}
					isArrayCreation = true; 
					if (la.kind == 99) {
						ArrayInitializer();
						isArrayCreation = false;
						/* From the specification point of view (14.5.6) this would be an
						   array creation expression, but csc does allow element access
						   on an initialized array creation expression so we allow it too.
						   The same holds for the ArrayInitializer only alternative below.
						*/
						
					}
				} else if (la.kind == 99) {
					ArrayInitializer();
					if (type != TypeKind.array) Error("array type expected");
					isArrayCreation = true;
					
				} else SynErr(209);
			} else if (la.kind == 99) {
				AnonymousObjectInitializer();
			} else if (la.kind == 100) {
				int dims = 1; 
				Get();
				while (la.kind == 90) {
					Get();
					dims++; 
				}
				Expect(116);
				ArrayInitializer();
				isArrayCreation = true; 
			} else SynErr(210);
			break;
		}
		case 74: {
			Get();
			Expect(101);
			Type(out type, true);
			Expect(117);
			break;
		}
		case 17: {
			Get();
			Expect(101);
			Expression();
			Expect(117);
			break;
		}
		case 77: {
			Get();
			Expect(101);
			Expression();
			Expect(117);
			break;
		}
		case 22: {
			Get();
			Expect(101);
			Type(out type, true);
			Expect(117);
			break;
		}
		case 23: {
			Get();
			if (la.kind == 101) {
				Get();
				if (StartOf(18)) {
					AnonymousMethodParameter();
					while (la.kind == 90) {
						Get();
						AnonymousMethodParameter();
					}
				}
				Expect(117);
			}
			Block();
			break;
		}
		case 64: {
			Get();
			Expect(101);
			Type(out type, false);
			Expect(117);
			break;
		}
		default: SynErr(211); break;
		}
		while (StartOf(30)) {
			switch (la.kind) {
			case 98: {
				Get();
				break;
			}
			case 91: {
				Get();
				break;
			}
			case 145: {
				Get();
				Expect(1);
				if (IsGeneric()) {
					TypeArgumentList();
				}
				break;
			}
			case 93: {
				Get();
				Expect(1);
				if (IsGeneric()) {
					TypeArgumentList();
				}
				break;
			}
			case 101: {
				Get();
				if (StartOf(15)) {
					Argument();
					while (la.kind == 90) {
						Get();
						Argument();
					}
				}
				Expect(117);
				break;
			}
			case 100: {
				if (isArrayCreation) Error("element access not allowed on array creation"); 
				Get();
				Expression();
				while (la.kind == 90) {
					Get();
					Expression();
				}
				Expect(116);
				break;
			}
			}
		}
	}

	void Literal() {
		switch (la.kind) {
		case 2: {
			Get();
			break;
		}
		case 3: {
			Get();
			break;
		}
		case 4: {
			Get();
			break;
		}
		case 5: {
			Get();
			break;
		}
		case 72: {
			Get();
			break;
		}
		case 31: {
			Get();
			break;
		}
		case 49: {
			Get();
			break;
		}
		default: SynErr(212); break;
		}
	}

	void ObjectOrCollectionInitializer() {
		Expect(99);
		if (StartOf(31)) {
			MemberOrElementInitializer();
			while (la.kind == _comma && Peek(1).kind != _rbrace) {
				Expect(90);
				MemberOrElementInitializer();
			}
			if (la.kind == 90) {
				Get();
			}
		}
		Expect(115);
	}

	void AnonymousObjectInitializer() {
		Expect(99);
		if (StartOf(19)) {
			MemberDeclaratorList();
		}
		Expect(115);
	}

	void MemberDeclaratorList() {
		MemberDeclarator();
		if (la.kind == 90) {
			Get();
			if (StartOf(19)) {
				MemberDeclaratorList();
			}
		}
	}

	void MemberDeclarator() {
		if (IsAssignment()) {
			Expect(1);
			Expect(88);
		}
		Expression();
	}

	void MemberOrElementInitializer() {
		if (IsAssignment()) {
			Expect(1);
			Expect(88);
			if (StartOf(19)) {
				Expression();
			} else if (la.kind == 99) {
				ObjectOrCollectionInitializer();
			} else SynErr(213);
		} else if (StartOf(31)) {
			if (StartOf(15)) {
				Argument();
			} else {
				Get();
				Argument();
				while (la.kind == 90) {
					Get();
					Argument();
				}
				Expect(115);
			}
		} else SynErr(214);
	}

	void ImplicitAnonymousFunctionParameter() {
		Expect(1);
	}

	void ImplicitTypedLambdaBody() {
		if (la.kind == 99) {
			Block();
		} else if (StartOf(19)) {
			Expression();
		} else SynErr(215);
	}

	void FromClause() {
		TypeKind type; 
		Expect(127);
		if (Peek(1).kind != _in) {
			Type(out type, false);
		}
		Expect(1);
		Expect(40);
		Expression();
	}

	void QueryBody() {
		while (StartOf(32)) {
			QueryBodyClause();
		}
		if (la.kind == 137) {
			SelectClause();
		} else if (la.kind == 138) {
			GroupClause();
		} else SynErr(216);
		if (la.kind == 132) {
			Get();
			Expect(1);
			QueryBody();
		}
	}

	void QueryBodyClause() {
		if (la.kind == 127) {
			FromClause();
		} else if (la.kind == 133) {
			LetClause();
		} else if (la.kind == 128) {
			WhereClause();
		} else if (la.kind == 129) {
			JoinClause();
		} else if (la.kind == 134) {
			OrderByClause();
		} else SynErr(217);
	}

	void SelectClause() {
		Expect(137);
		Expression();
	}

	void GroupClause() {
		Expect(138);
		Expression();
		Expect(139);
		Expression();
	}

	void LetClause() {
		Expect(133);
		Expect(1);
		Expect(88);
		Expression();
	}

	void WhereClause() {
		Expect(128);
		Expression();
	}

	void JoinClause() {
		TypeKind type; 
		Expect(129);
		if (Peek(1).kind != _in) {
			Type(out type, false);
		}
		Expect(1);
		Expect(40);
		Expression();
		Expect(130);
		Expression();
		Expect(131);
		Expression();
		if (la.kind == 132) {
			Get();
			Expect(1);
		}
	}

	void OrderByClause() {
		Expect(134);
		Ordering();
		while (la.kind == 90) {
			Get();
			Ordering();
		}
	}

	void Ordering() {
		Expression();
		if (la.kind == 135 || la.kind == 136) {
			if (la.kind == 135) {
				Get();
			} else {
				Get();
			}
		}
	}

	void CsxTag(out PElement result) {
		result = new PElement();                 
		PElement e; PVerbose v;                  
		Expect(103);
		CsxName(result);
		while (la.kind == 1) {
			PVerbose attr; 
			CsxAttr(out attr);
			result.Attributes.Add(attr);             
		}
		if (la.kind == 126) {
			Get();
		} else if (la.kind == 96) {
			Get();
			while (la.kind == 99 || la.kind == 103) {
				if (la.kind == 103) {
					CsxTag(out e);
					result.Children.Add(e);                 
				} else {
					CsxEmb(out v);
					result.Children.Add(v);                 
				}
			}
			Expect(125);
			var end = new PNode(); 
			CsxName(end);
			Expect(96);
			if (result.Name != end.Name) Error(string.Format("Open/close XML namespace mismatch. Expected {0}, found: {1}", result.Name, end.Name)); 
			if (result.Ns != end.Ns) Error(string.Format("Open/close XML namespace mismatch. Expected {0}, found: {1}", result.Ns, end.Ns)); 
		} else SynErr(218);
	}

	void CsxName(PNode result) {
		Expect(1);
		result.Name = t.val; result.Ns = null;   
		if (la.kind == 89) {
			Get();
			Expect(1);
			result.Ns = result.Name; 
			result.Name = t.val;                     
		}
		while (la.kind == 93) {
			Get();
			Expect(1);
			result.Name += "." + t.val;              
		}
	}

	void CsxAttr(out PVerbose result) {
		result = new PVerbose();                 
		CsxName(result);
		Expect(88);
		if (la.kind == 5) {
			Get();
			result.Value = t.val;                    
		} else if (la.kind == 99) {
			Get();
			BeginCapture(Mode.CSharp);               
			Expression();
			result.Value = EndCapture();             
			Expect(115);
		} else SynErr(219);
	}

	void CsxEmb(out PVerbose result) {
		result = new PVerbose();                 
		Expect(99);
		BeginCapture(Mode.CSharp);               
		Expression();
		result.Value = EndCapture();             
		Expect(115);
	}



  public void Parse() 
  {
    la = new Token { val = "" };
    Get();
		CS3();

    Expect(0);
  }
  
  static readonly bool[,] set = 
  {
		{T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,x,x, x,x,T,x, x,x,x,x, x,x,x,x, x,x,T,x, x,x,x,T, x,x,x,T, x,x,T,x, x,x,x,x, x,x,x,x, x,x,T,T, x,x,x,T, T,x,x,x, x,T,x,T, T,T,T,x, x,x,T,x, x,x,T,x, T,x,x,x, x,x,x,x, x,x,T,x, x,T,x,T, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,x,x, x,x,T,x, x,x,x,x, x,x,x,x, x,x,T,x, x,x,x,T, x,x,x,T, x,x,T,x, x,x,x,x, x,x,x,x, x,x,T,T, x,x,x,x, T,x,x,x, x,T,x,T, T,T,T,x, x,x,T,x, x,x,T,x, T,x,x,x, x,x,x,x, x,x,T,x, x,T,x,T, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,x,x,x, x,x,T,T, T,T,T,T, T,T,T,T, T,T,T,T, T,T,T,T, T,T,T,T, T,T,T,T, T,T,T,T, T,T,T,T, T,T,T,T, T,T,T,T, T,T,T,T, T,T,T,T, T,T,T,T, T,T,T,T, T,T,T,T, T,T,T,T, T,T,T,T, T,T,T,T, T,T,T,T, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,x,x,x, x,x,T,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,T,x, x,x,x,x, x,x,x,x, x,x,x,T, x,x,x,x, T,x,x,x, x,T,x,T, T,T,T,x, x,x,T,x, x,x,T,x, x,x,x,x, x,x,x,x, x,x,T,x, x,T,x,T, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,T,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,T,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,x,x, x,x,x,x, x,x,x,T, x,T,x,x, T,x,x,x, x,T,x,x, x,T,x,x, T,x,x,x, x,x,T,x, x,x,x,x, x,T,x,x, x,x,T,x, T,x,T,x, x,x,x,x, x,x,x,x, x,T,x,T, x,x,x,T, x,x,x,x, x,x,x,T, T,x,T,T, x,x,T,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,x,x, x,x,x,x, x,x,x,T, x,T,x,x, T,x,x,x, x,T,x,x, x,T,x,x, x,x,x,x, x,x,T,x, x,x,x,x, x,T,x,x, x,x,T,x, x,x,T,x, T,x,T,x, x,x,x,T, x,T,x,T, x,x,x,T, x,x,T,x, x,x,x,T, T,x,x,T, x,x,T,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,T,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,T,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,T, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,x,x, x,x,T,x, x,x,x,T, x,T,x,x, T,x,T,T, x,T,x,T, x,T,x,T, T,T,T,x, x,T,T,x, x,x,x,T, x,T,T,T, x,x,T,x, T,x,T,x, x,T,x,T, T,T,T,x, x,T,T,T, x,x,T,T, T,x,x,x, x,x,x,T, T,x,T,T, x,T,T,T, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,T, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,x,x, x,x,T,x, x,x,x,T, x,T,x,x, T,x,T,T, x,T,x,T, x,T,x,T, T,T,T,x, x,T,T,x, x,x,x,T, x,T,T,T, x,x,T,x, T,x,T,x, x,T,x,T, T,T,T,x, x,T,T,T, x,x,T,T, T,x,x,x, x,x,x,T, T,x,T,T, x,T,T,T, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,x,x, x,x,x,x, x,x,x,T, x,T,x,x, T,x,x,x, x,T,x,x, x,T,x,x, x,x,x,x, x,x,T,x, x,x,x,x, x,T,x,x, x,x,T,x, T,x,T,x, x,x,x,x, x,x,x,x, x,T,x,T, x,x,x,T, x,x,x,x, x,x,x,T, T,x,T,T, x,x,T,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,x,x,x, x,x,x,x, x,x,x,T, x,T,x,x, T,x,x,x, x,T,x,x, x,T,x,x, x,x,x,x, x,x,T,x, x,x,x,x, x,T,x,x, x,x,T,x, x,x,x,x, x,x,x,x, x,x,x,x, x,T,x,T, x,x,x,x, x,x,x,x, x,x,x,T, T,x,x,T, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,x,x, x,x,x,x, x,x,x,T, x,T,x,x, T,x,x,x, x,T,x,x, x,T,x,x, x,x,x,x, x,x,T,x, x,x,x,x, x,T,x,x, x,x,T,x, x,x,T,x, T,x,x,x, x,x,x,T, x,T,x,T, x,x,x,T, x,x,T,x, x,x,x,T, T,x,x,T, x,x,T,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,x,x, x,x,x,x, x,x,x,T, x,T,x,x, T,x,T,T, x,T,x,T, x,T,x,T, T,T,x,x, x,T,T,x, x,x,x,T, x,T,T,x, x,x,T,x, x,x,T,x, x,x,x,x, x,x,x,x, x,T,x,T, x,x,x,T, T,x,x,x, x,x,x,T, T,x,x,T, x,x,T,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,T,T, T,T,x,x, T,x,T,T, x,T,x,x, T,T,x,x, x,T,T,T, x,T,x,x, x,x,x,T, x,x,T,x, x,x,x,x, x,T,x,x, x,x,T,x, T,T,T,x, T,x,x,x, x,x,x,T, x,T,x,T, T,x,x,T, x,x,T,x, T,x,T,T, T,T,x,T, x,x,x,x, x,T,x,x, x,x,x,T, x,x,x,x, x,x,T,x, x,T,x,T, x,T,x,x, x,T,x,x, T,x,x,x, x,x,x,T, T,x,x,x, x,x,x,T, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,x,x, x,x,x,x, x,x,x,T, x,T,x,x, T,x,x,x, x,T,x,x, x,T,x,x, x,x,x,x, x,x,T,x, x,x,x,x, x,T,x,x, x,x,T,x, x,x,T,x, x,x,x,x, x,x,x,x, x,T,x,T, x,x,x,T, x,x,x,x, x,x,x,T, T,x,x,T, x,x,T,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,T,T, T,T,x,x, x,x,T,T, T,T,x,x, T,T,x,T, T,T,T,T, T,T,x,x, x,x,x,T, x,T,T,T, T,T,T,x, x,T,x,x, x,T,T,x, T,T,T,x, x,x,x,x, x,x,x,x, T,T,x,T, T,x,x,T, x,T,T,T, T,T,T,T, T,T,T,T, T,x,T,x, T,T,x,x, x,x,x,T, x,x,x,x, x,x,T,T, x,T,x,x, x,T,x,x, x,T,x,x, T,x,x,x, x,x,T,T, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,x,x, x,x,x,x, x,x,x,T, x,T,x,x, T,x,x,x, x,T,x,x, x,T,x,x, x,x,x,x, x,x,T,x, x,x,x,x, x,T,x,x, x,x,T,x, x,x,T,x, T,x,x,x, x,x,x,T, x,T,x,T, x,x,x,T, x,x,x,x, x,x,x,T, T,x,x,T, x,x,T,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,T,T, T,T,x,x, T,x,T,T, x,T,x,x, T,T,x,x, x,T,T,T, x,T,x,x, x,x,x,T, x,x,T,x, x,x,x,x, x,T,x,x, x,x,T,x, T,T,T,x, x,x,x,x, x,x,x,x, x,T,x,T, T,x,x,T, x,x,T,x, T,x,T,T, T,T,x,T, x,x,x,x, x,T,x,x, x,x,x,T, x,x,x,x, x,x,T,x, x,T,x,T, x,T,x,x, x,T,x,x, T,x,x,x, x,x,x,T, T,x,x,x, x,x,x,T, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,T,T, T,T,x,x, x,x,T,T, x,T,x,x, T,T,x,x, x,T,T,T, x,T,x,x, x,x,x,T, x,x,T,x, x,x,x,x, x,T,x,x, x,x,T,x, T,T,T,x, x,x,x,x, x,x,x,x, x,T,x,T, T,x,x,T, x,x,T,x, T,x,T,T, T,T,x,T, x,x,x,x, x,T,x,x, x,x,x,T, x,x,x,x, x,x,T,x, x,T,x,x, x,T,x,x, x,T,x,x, T,x,x,x, x,x,x,T, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,x,x,x, x,x,x,x, x,T,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,T,x,x, x,T,T,x, x,x,x,T, T,T,x,x, x,x,x,T, T,T,x,x, T,x,T,x, T,x,T,T, T,T,T,x, T,x,x,T, T,x,x,T, T,T,T,T, T,T,T,T, T,T,T,T, T,T,T,T, T,x,x,x},
		{x,T,x,x, x,x,T,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,T,x, x,x,x,x, x,x,x,x, x,x,x,T, x,x,x,x, T,x,x,x, x,T,x,T, T,T,T,x, x,x,T,x, x,x,T,x, x,x,x,x, x,x,x,x, x,x,T,x, x,T,x,T, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,T,T, T,T,x,x, T,x,T,T, x,T,x,x, T,T,x,x, x,T,T,T, x,T,x,x, x,x,x,T, x,x,T,x, x,x,x,x, x,T,x,x, x,x,T,x, T,T,T,x, x,x,x,x, x,x,x,x, x,T,x,T, T,x,x,T, x,x,T,x, T,x,T,T, T,T,x,T, x,x,x,x, x,T,x,x, x,x,x,T, x,x,x,x, x,x,T,T, x,T,x,T, x,T,x,x, x,T,x,x, T,x,x,x, x,x,x,T, T,x,x,x, x,x,x,T, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,x,x,x, x,x,x,x, x,x,x,x, x,T,x,x, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,T,x,x, x,x,T,x, x,x,x,x, x,x,x,x, x,x,x,x, x,T,x,T, x,x,x,x, x,x,x,x, x,x,x,T, T,x,x,T, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,T,T, T,T,x,x, x,x,T,T, T,T,x,x, T,T,x,x, T,T,T,T, T,T,x,x, x,x,x,T, x,T,T,T, T,T,T,x, x,T,x,x, x,T,T,x, T,T,T,x, x,x,x,x, x,x,x,x, T,T,x,T, T,x,x,T, x,T,T,T, T,T,T,T, T,T,T,T, T,x,x,x, T,T,x,x, x,x,x,T, x,x,x,x, x,x,T,T, x,T,x,x, x,T,x,x, x,T,x,x, T,x,x,x, x,x,T,T, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,T,T,T, T,T,x,x, x,x,T,T, x,T,x,x, T,T,x,x, x,T,T,T, x,T,x,x, x,x,x,T, x,x,T,x, x,x,x,x, x,T,x,x, x,x,T,x, T,T,T,x, x,x,x,x, x,x,x,x, x,T,x,T, T,x,x,T, x,x,T,x, T,x,T,T, T,T,x,T, x,x,T,x, x,T,x,x, x,x,x,T, x,x,x,x, x,x,T,x, x,T,x,x, x,T,x,x, x,T,x,x, T,x,x,x, x,x,x,T, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,T,x, T,x,x,x, T,x,x,x, T,x,x,x, x,x,T,x, x,x,T,T, x,x,x,T, x,T,x,x, x,x,x,x, x,T,T,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,x,x,x, x,x,x,x, x,T,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, T,T,x,x, x,x,x,T, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, T,T,x,x, x,x,x,T, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, T,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,T, x,T,x,x, x,x,T,x, T,T,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,T,x,x},
		{x,T,T,T, T,T,x,x, T,x,T,T, x,T,x,x, T,T,x,x, x,T,T,T, x,T,x,x, x,x,x,T, x,x,T,x, x,x,x,x, x,T,x,x, x,x,T,x, T,T,T,x, T,x,x,x, x,x,x,T, x,T,x,T, T,x,x,T, x,x,T,x, T,x,T,T, T,T,x,T, x,x,x,x, x,T,x,x, x,x,x,T, x,x,x,x, x,x,T,T, x,T,x,T, x,T,x,x, x,T,x,x, T,x,x,x, x,x,x,T, T,x,x,x, x,x,x,T, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x},
		{x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,x, x,x,x,T, T,T,x,x, x,T,T,x, x,x,x,x, x,x,x,x, x,x,x,x}

  };
}

public class Errors 
{
  public int Count = 0;                                    // number of errors detected
  public System.IO.TextWriter ErrorStream = Console.Out;   // error messages go to this stream
  public string ErrMsgFormat = "-- line {0} col {1}: {2}"; // 0=line, 1=column, 2=text
  
  public static string GetErrorText(int n)
  {
    string s;
    switch (n) 
    {
      default: return "error " + n; 
			case 0: s = "EOF expected"; break;
			case 1: s = "ident expected"; break;
			case 2: s = "intCon expected"; break;
			case 3: s = "realCon expected"; break;
			case 4: s = "charCon expected"; break;
			case 5: s = "stringCon expected"; break;
			case 6: s = "abstract expected"; break;
			case 7: s = "async expected"; break;
			case 8: s = "await expected"; break;
			case 9: s = "as expected"; break;
			case 10: s = "base expected"; break;
			case 11: s = "bool expected"; break;
			case 12: s = "break expected"; break;
			case 13: s = "byte expected"; break;
			case 14: s = "case expected"; break;
			case 15: s = "catch expected"; break;
			case 16: s = "char expected"; break;
			case 17: s = "checked expected"; break;
			case 18: s = "class expected"; break;
			case 19: s = "const expected"; break;
			case 20: s = "continue expected"; break;
			case 21: s = "decimal expected"; break;
			case 22: s = "default expected"; break;
			case 23: s = "delegate expected"; break;
			case 24: s = "do expected"; break;
			case 25: s = "double expected"; break;
			case 26: s = "else expected"; break;
			case 27: s = "enum expected"; break;
			case 28: s = "event expected"; break;
			case 29: s = "explicit expected"; break;
			case 30: s = "extern expected"; break;
			case 31: s = "false expected"; break;
			case 32: s = "finally expected"; break;
			case 33: s = "fixed expected"; break;
			case 34: s = "float expected"; break;
			case 35: s = "for expected"; break;
			case 36: s = "foreach expected"; break;
			case 37: s = "goto expected"; break;
			case 38: s = "if expected"; break;
			case 39: s = "implicit expected"; break;
			case 40: s = "in expected"; break;
			case 41: s = "int expected"; break;
			case 42: s = "interface expected"; break;
			case 43: s = "internal expected"; break;
			case 44: s = "is expected"; break;
			case 45: s = "lock expected"; break;
			case 46: s = "long expected"; break;
			case 47: s = "namespace expected"; break;
			case 48: s = "new expected"; break;
			case 49: s = "null expected"; break;
			case 50: s = "object expected"; break;
			case 51: s = "operator expected"; break;
			case 52: s = "outKW expected"; break;
			case 53: s = "override expected"; break;
			case 54: s = "params expected"; break;
			case 55: s = "private expected"; break;
			case 56: s = "protected expected"; break;
			case 57: s = "public expected"; break;
			case 58: s = "readonly expected"; break;
			case 59: s = "ref expected"; break;
			case 60: s = "return expected"; break;
			case 61: s = "sbyte expected"; break;
			case 62: s = "sealed expected"; break;
			case 63: s = "short expected"; break;
			case 64: s = "sizeof expected"; break;
			case 65: s = "stackalloc expected"; break;
			case 66: s = "static expected"; break;
			case 67: s = "string expected"; break;
			case 68: s = "struct expected"; break;
			case 69: s = "switch expected"; break;
			case 70: s = "this expected"; break;
			case 71: s = "throw expected"; break;
			case 72: s = "true expected"; break;
			case 73: s = "try expected"; break;
			case 74: s = "typeof expected"; break;
			case 75: s = "uint expected"; break;
			case 76: s = "ulong expected"; break;
			case 77: s = "unchecked expected"; break;
			case 78: s = "unsafe expected"; break;
			case 79: s = "ushort expected"; break;
			case 80: s = "usingKW expected"; break;
			case 81: s = "virtual expected"; break;
			case 82: s = "void expected"; break;
			case 83: s = "volatile expected"; break;
			case 84: s = "while expected"; break;
			case 85: s = "and expected"; break;
			case 86: s = "andassgn expected"; break;
			case 87: s = "arrow expected"; break;
			case 88: s = "assgn expected"; break;
			case 89: s = "colon expected"; break;
			case 90: s = "comma expected"; break;
			case 91: s = "dec expected"; break;
			case 92: s = "divassgn expected"; break;
			case 93: s = "dot expected"; break;
			case 94: s = "dblcolon expected"; break;
			case 95: s = "eq expected"; break;
			case 96: s = "gt expected"; break;
			case 97: s = "gteq expected"; break;
			case 98: s = "inc expected"; break;
			case 99: s = "lbrace expected"; break;
			case 100: s = "lbrack expected"; break;
			case 101: s = "lpar expected"; break;
			case 102: s = "lshassgn expected"; break;
			case 103: s = "lt expected"; break;
			case 104: s = "ltlt expected"; break;
			case 105: s = "minus expected"; break;
			case 106: s = "minusassgn expected"; break;
			case 107: s = "modassgn expected"; break;
			case 108: s = "neq expected"; break;
			case 109: s = "not expected"; break;
			case 110: s = "nullCoal expected"; break;
			case 111: s = "orassgn expected"; break;
			case 112: s = "plus expected"; break;
			case 113: s = "plusassgn expected"; break;
			case 114: s = "question expected"; break;
			case 115: s = "rbrace expected"; break;
			case 116: s = "rbrack expected"; break;
			case 117: s = "rpar expected"; break;
			case 118: s = "scolon expected"; break;
			case 119: s = "tilde expected"; break;
			case 120: s = "times expected"; break;
			case 121: s = "timesassgn expected"; break;
			case 122: s = "xorassgn expected"; break;
			case 123: s = "andand expected"; break;
			case 124: s = "lteq expected"; break;
			case 125: s = "closeTag expected"; break;
			case 126: s = "endTag expected"; break;
			case 127: s = "from expected"; break;
			case 128: s = "where expected"; break;
			case 129: s = "join expected"; break;
			case 130: s = "on expected"; break;
			case 131: s = "equals expected"; break;
			case 132: s = "into expected"; break;
			case 133: s = "let expected"; break;
			case 134: s = "orderby expected"; break;
			case 135: s = "ascending expected"; break;
			case 136: s = "descending expected"; break;
			case 137: s = "select expected"; break;
			case 138: s = "group expected"; break;
			case 139: s = "by expected"; break;
			case 140: s = "\"||\" expected"; break;
			case 141: s = "\"|\" expected"; break;
			case 142: s = "\"^\" expected"; break;
			case 143: s = "\"/\" expected"; break;
			case 144: s = "\"%\" expected"; break;
			case 145: s = "\"->\" expected"; break;
			case 146: s = "??? expected"; break;
			case 147: s = "invalid NamespaceMemberDeclaration"; break;
			case 148: s = "invalid Attributes"; break;
			case 149: s = "invalid TypeDeclaration"; break;
			case 150: s = "invalid TypeDeclaration"; break;
			case 151: s = "invalid TypeParameterConstraintsClause"; break;
			case 152: s = "invalid InterfaceMemberDeclaration"; break;
			case 153: s = "invalid InterfaceMemberDeclaration"; break;
			case 154: s = "invalid InterfaceMemberDeclaration"; break;
			case 155: s = "invalid IntegralType"; break;
			case 156: s = "invalid Type"; break;
			case 157: s = "invalid FormalParameterList"; break;
			case 158: s = "invalid ClassType"; break;
			case 159: s = "invalid ClassMemberDeclaration"; break;
			case 160: s = "invalid ClassMemberDeclaration"; break;
			case 161: s = "invalid StructMemberDeclaration"; break;
			case 162: s = "invalid StructMemberDeclaration"; break;
			case 163: s = "invalid StructMemberDeclaration"; break;
			case 164: s = "invalid StructMemberDeclaration"; break;
			case 165: s = "invalid StructMemberDeclaration"; break;
			case 166: s = "invalid StructMemberDeclaration"; break;
			case 167: s = "invalid StructMemberDeclaration"; break;
			case 168: s = "invalid StructMemberDeclaration"; break;
			case 169: s = "invalid StructMemberDeclaration"; break;
			case 170: s = "invalid StructMemberDeclaration"; break;
			case 171: s = "invalid StructMemberDeclaration"; break;
			case 172: s = "invalid Expression"; break;
			case 173: s = "invalid Expression"; break;
			case 174: s = "invalid Expression"; break;
			case 175: s = "invalid EventAccessorDeclarations"; break;
			case 176: s = "invalid EventAccessorDeclarations"; break;
			case 177: s = "invalid OverloadableOp"; break;
			case 178: s = "invalid AccessorDeclarations"; break;
			case 179: s = "invalid AccessorDeclarations"; break;
			case 180: s = "invalid AccessorDeclarations"; break;
			case 181: s = "invalid AccessorDeclarations"; break;
			case 182: s = "invalid InterfaceAccessors"; break;
			case 183: s = "invalid InterfaceAccessors"; break;
			case 184: s = "invalid LocalVariableDeclarator"; break;
			case 185: s = "invalid LocalVariableDeclarator"; break;
			case 186: s = "invalid VariableInitializer"; break;
			case 187: s = "invalid Keyword"; break;
			case 188: s = "invalid AttributeArguments"; break;
			case 189: s = "invalid PrimitiveType"; break;
			case 190: s = "invalid PointerOrArray"; break;
			case 191: s = "invalid ResolvedType"; break;
			case 192: s = "invalid TypeArgumentList"; break;
			case 193: s = "invalid TypeArgumentList"; break;
			case 194: s = "invalid InternalClassType"; break;
			case 195: s = "invalid Statement"; break;
			case 196: s = "invalid EmbeddedStatement"; break;
			case 197: s = "invalid EmbeddedStatement"; break;
			case 198: s = "invalid EmbeddedStatement"; break;
			case 199: s = "invalid EmbeddedStatement"; break;
			case 200: s = "invalid StatementExpression"; break;
			case 201: s = "invalid ForInitializer"; break;
			case 202: s = "invalid CatchClauses"; break;
			case 203: s = "invalid ResourceAcquisition"; break;
			case 204: s = "invalid Unary"; break;
			case 205: s = "invalid AssignmentOperator"; break;
			case 206: s = "invalid SwitchLabel"; break;
			case 207: s = "invalid ImplicitLambdaExpression"; break;
			case 208: s = "invalid ShiftExpr"; break;
			case 209: s = "invalid Primary"; break;
			case 210: s = "invalid Primary"; break;
			case 211: s = "invalid Primary"; break;
			case 212: s = "invalid Literal"; break;
			case 213: s = "invalid MemberOrElementInitializer"; break;
			case 214: s = "invalid MemberOrElementInitializer"; break;
			case 215: s = "invalid ImplicitTypedLambdaBody"; break;
			case 216: s = "invalid QueryBody"; break;
			case 217: s = "invalid QueryBodyClause"; break;
			case 218: s = "invalid CsxTag"; break;
			case 219: s = "invalid CsxAttr"; break;

    }
    return s;
  }


  public virtual void SynErr(int line, int col, int n) 
  {
    ErrorStream.WriteLine(ErrMsgFormat, line, col, GetErrorText(n));
    Count++;
  }

  public virtual void SemErr(int line, int col, string s) 
  {
    ErrorStream.WriteLine(ErrMsgFormat, line, col, s);
    Count++;
  }
  
  public virtual void SemErr(string s) 
  {
    ErrorStream.WriteLine(s);
    Count++;
  }
  
  public virtual void Warning(int line, int col, string s) 
  {
    ErrorStream.WriteLine(ErrMsgFormat, line, col, s);
  }
  
  public virtual void Warning(string s) 
  {
    ErrorStream.WriteLine(s);
  }
}

public class FatalError: Exception 
{
  public FatalError(string m): base(m) { }
}

}