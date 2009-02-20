// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision: 2201 $</version>
// </file>

// This file is automatically generated - any changes will be lost

#pragma warning disable 1591

namespace Debugger.Wrappers.CorSym
{
	using System;
	
	
	public partial class CorSymBinder_SxS
	{
		
		private Debugger.Interop.CorSym.CorSymBinder_SxS wrappedObject;
		
		internal Debugger.Interop.CorSym.CorSymBinder_SxS WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public CorSymBinder_SxS(Debugger.Interop.CorSym.CorSymBinder_SxS wrappedObject)
		{
			this.wrappedObject = wrappedObject;
			ResourceManager.TrackCOMObject(wrappedObject, typeof(CorSymBinder_SxS));
		}
		
		public static CorSymBinder_SxS Wrap(Debugger.Interop.CorSym.CorSymBinder_SxS objectToWrap)
		{
			if ((objectToWrap != null))
			{
				return new CorSymBinder_SxS(objectToWrap);
			} else
			{
				return null;
			}
		}
		
		~CorSymBinder_SxS()
		{
			object o = wrappedObject;
			wrappedObject = null;
			ResourceManager.ReleaseCOMObject(o, typeof(CorSymBinder_SxS));
		}
		
		public bool Is<T>() where T: class
		{
			System.Reflection.ConstructorInfo ctor = typeof(T).GetConstructors()[0];
			System.Type paramType = ctor.GetParameters()[0].ParameterType;
			return paramType.IsInstanceOfType(this.WrappedObject);
		}
		
		public T As<T>() where T: class
		{
			try {
				return CastTo<T>();
			} catch {
				return null;
			}
		}
		
		public T CastTo<T>() where T: class
		{
			return (T)Activator.CreateInstance(typeof(T), this.WrappedObject);
		}
		
		public static bool operator ==(CorSymBinder_SxS o1, CorSymBinder_SxS o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(CorSymBinder_SxS o1, CorSymBinder_SxS o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			CorSymBinder_SxS casted = o as CorSymBinder_SxS;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
	}
}

#pragma warning restore 1591
