using Mono.Cecil.Cil;
using System;
using System.IO;
using System.Reflection;

namespace Mono.Cecil
{
	public sealed class WriterParameters
	{
		private Stream symbol_stream;

		private ISymbolWriterProvider symbol_writer_provider;

		private bool write_symbols;

		private System.Reflection.StrongNameKeyPair key_pair;

		public System.Reflection.StrongNameKeyPair StrongNameKeyPair
		{
			get
			{
				return this.key_pair;
			}
			set
			{
				this.key_pair = value;
			}
		}

		public Stream SymbolStream
		{
			get
			{
				return this.symbol_stream;
			}
			set
			{
				this.symbol_stream = value;
			}
		}

		public ISymbolWriterProvider SymbolWriterProvider
		{
			get
			{
				return this.symbol_writer_provider;
			}
			set
			{
				this.symbol_writer_provider = value;
			}
		}

		public bool WriteSymbols
		{
			get
			{
				return this.write_symbols;
			}
			set
			{
				this.write_symbols = value;
			}
		}

		public WriterParameters()
		{
		}
	}
}