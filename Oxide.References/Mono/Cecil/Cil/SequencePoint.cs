using System;

namespace Mono.Cecil.Cil
{
	public sealed class SequencePoint
	{
		private Mono.Cecil.Cil.Document document;

		private int start_line;

		private int start_column;

		private int end_line;

		private int end_column;

		public Mono.Cecil.Cil.Document Document
		{
			get
			{
				return this.document;
			}
			set
			{
				this.document = value;
			}
		}

		public int EndColumn
		{
			get
			{
				return this.end_column;
			}
			set
			{
				this.end_column = value;
			}
		}

		public int EndLine
		{
			get
			{
				return this.end_line;
			}
			set
			{
				this.end_line = value;
			}
		}

		public int StartColumn
		{
			get
			{
				return this.start_column;
			}
			set
			{
				this.start_column = value;
			}
		}

		public int StartLine
		{
			get
			{
				return this.start_line;
			}
			set
			{
				this.start_line = value;
			}
		}

		public SequencePoint(Mono.Cecil.Cil.Document document)
		{
			this.document = document;
		}
	}
}