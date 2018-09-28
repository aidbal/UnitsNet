﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     In chemistry, the molar mass M is a physical property defined as the mass of a given substance (chemical element or chemical compound) divided by the amount of substance.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class MolarMass : IQuantity
#else
    public partial struct MolarMass : IQuantity, IComparable, IComparable<MolarMass>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MolarMassUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public MolarMassUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static MolarMass()
        {
            BaseDimensions = new BaseDimensions(0, 1, 0, 0, 0, -1, 0);
        }

        /// <summary>
        ///     Creates the quantity with the given value in the base unit KilogramPerMole.
        /// </summary>
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public MolarMass(double kilogramspermole)
        {
            _value = Convert.ToDouble(kilogramspermole);
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">Numeric value.</param>
        /// <param name="unit">Unit representation.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
#if WINDOWS_UWP
        private
#else
        public
#endif
        MolarMass(double numericValue, MolarMassUnit unit)
        {
            _value = numericValue;
            _unit = unit;
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit KilogramPerMole.
        /// </summary>
        /// <param name="kilogramspermole">Value assuming base unit KilogramPerMole.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        MolarMass(long kilogramspermole) : this(Convert.ToDouble(kilogramspermole), BaseUnit) { }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit KilogramPerMole.
        /// </summary>
        /// <param name="kilogramspermole">Value assuming base unit KilogramPerMole.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        MolarMass(decimal kilogramspermole) : this(Convert.ToDouble(kilogramspermole), BaseUnit) { }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.MolarMass;

        /// <summary>
        ///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static MolarMassUnit BaseUnit => MolarMassUnit.KilogramPerMole;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the MolarMass quantity.
        /// </summary>
        public static MolarMassUnit[] Units { get; } = Enum.GetValues(typeof(MolarMassUnit)).Cast<MolarMassUnit>().Except(new MolarMassUnit[]{ MolarMassUnit.Undefined }).ToArray();

        /// <summary>
        ///     Get MolarMass in CentigramsPerMole.
        /// </summary>
        public double CentigramsPerMole => As(MolarMassUnit.CentigramPerMole);

        /// <summary>
        ///     Get MolarMass in DecagramsPerMole.
        /// </summary>
        public double DecagramsPerMole => As(MolarMassUnit.DecagramPerMole);

        /// <summary>
        ///     Get MolarMass in DecigramsPerMole.
        /// </summary>
        public double DecigramsPerMole => As(MolarMassUnit.DecigramPerMole);

        /// <summary>
        ///     Get MolarMass in GramsPerMole.
        /// </summary>
        public double GramsPerMole => As(MolarMassUnit.GramPerMole);

        /// <summary>
        ///     Get MolarMass in HectogramsPerMole.
        /// </summary>
        public double HectogramsPerMole => As(MolarMassUnit.HectogramPerMole);

        /// <summary>
        ///     Get MolarMass in KilogramsPerMole.
        /// </summary>
        public double KilogramsPerMole => As(MolarMassUnit.KilogramPerMole);

        /// <summary>
        ///     Get MolarMass in KilopoundsPerMole.
        /// </summary>
        public double KilopoundsPerMole => As(MolarMassUnit.KilopoundPerMole);

        /// <summary>
        ///     Get MolarMass in MegapoundsPerMole.
        /// </summary>
        public double MegapoundsPerMole => As(MolarMassUnit.MegapoundPerMole);

        /// <summary>
        ///     Get MolarMass in MicrogramsPerMole.
        /// </summary>
        public double MicrogramsPerMole => As(MolarMassUnit.MicrogramPerMole);

        /// <summary>
        ///     Get MolarMass in MilligramsPerMole.
        /// </summary>
        public double MilligramsPerMole => As(MolarMassUnit.MilligramPerMole);

        /// <summary>
        ///     Get MolarMass in NanogramsPerMole.
        /// </summary>
        public double NanogramsPerMole => As(MolarMassUnit.NanogramPerMole);

        /// <summary>
        ///     Get MolarMass in PoundsPerMole.
        /// </summary>
        public double PoundsPerMole => As(MolarMassUnit.PoundPerMole);

        #endregion

        #region Static

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit KilogramPerMole.
        /// </summary>
        public static MolarMass Zero => new MolarMass(0, BaseUnit);

        /// <summary>
        ///     Get MolarMass from CentigramsPerMole.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromCentigramsPerMole(double centigramspermole)
#else
        public static MolarMass FromCentigramsPerMole(QuantityValue centigramspermole)
#endif
        {
            double value = (double) centigramspermole;
            return new MolarMass(value, MolarMassUnit.CentigramPerMole);
        }

        /// <summary>
        ///     Get MolarMass from DecagramsPerMole.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromDecagramsPerMole(double decagramspermole)
#else
        public static MolarMass FromDecagramsPerMole(QuantityValue decagramspermole)
#endif
        {
            double value = (double) decagramspermole;
            return new MolarMass(value, MolarMassUnit.DecagramPerMole);
        }

        /// <summary>
        ///     Get MolarMass from DecigramsPerMole.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromDecigramsPerMole(double decigramspermole)
#else
        public static MolarMass FromDecigramsPerMole(QuantityValue decigramspermole)
#endif
        {
            double value = (double) decigramspermole;
            return new MolarMass(value, MolarMassUnit.DecigramPerMole);
        }

        /// <summary>
        ///     Get MolarMass from GramsPerMole.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromGramsPerMole(double gramspermole)
#else
        public static MolarMass FromGramsPerMole(QuantityValue gramspermole)
#endif
        {
            double value = (double) gramspermole;
            return new MolarMass(value, MolarMassUnit.GramPerMole);
        }

        /// <summary>
        ///     Get MolarMass from HectogramsPerMole.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromHectogramsPerMole(double hectogramspermole)
#else
        public static MolarMass FromHectogramsPerMole(QuantityValue hectogramspermole)
#endif
        {
            double value = (double) hectogramspermole;
            return new MolarMass(value, MolarMassUnit.HectogramPerMole);
        }

        /// <summary>
        ///     Get MolarMass from KilogramsPerMole.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromKilogramsPerMole(double kilogramspermole)
#else
        public static MolarMass FromKilogramsPerMole(QuantityValue kilogramspermole)
#endif
        {
            double value = (double) kilogramspermole;
            return new MolarMass(value, MolarMassUnit.KilogramPerMole);
        }

        /// <summary>
        ///     Get MolarMass from KilopoundsPerMole.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromKilopoundsPerMole(double kilopoundspermole)
#else
        public static MolarMass FromKilopoundsPerMole(QuantityValue kilopoundspermole)
#endif
        {
            double value = (double) kilopoundspermole;
            return new MolarMass(value, MolarMassUnit.KilopoundPerMole);
        }

        /// <summary>
        ///     Get MolarMass from MegapoundsPerMole.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromMegapoundsPerMole(double megapoundspermole)
#else
        public static MolarMass FromMegapoundsPerMole(QuantityValue megapoundspermole)
#endif
        {
            double value = (double) megapoundspermole;
            return new MolarMass(value, MolarMassUnit.MegapoundPerMole);
        }

        /// <summary>
        ///     Get MolarMass from MicrogramsPerMole.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromMicrogramsPerMole(double microgramspermole)
#else
        public static MolarMass FromMicrogramsPerMole(QuantityValue microgramspermole)
#endif
        {
            double value = (double) microgramspermole;
            return new MolarMass(value, MolarMassUnit.MicrogramPerMole);
        }

        /// <summary>
        ///     Get MolarMass from MilligramsPerMole.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromMilligramsPerMole(double milligramspermole)
#else
        public static MolarMass FromMilligramsPerMole(QuantityValue milligramspermole)
#endif
        {
            double value = (double) milligramspermole;
            return new MolarMass(value, MolarMassUnit.MilligramPerMole);
        }

        /// <summary>
        ///     Get MolarMass from NanogramsPerMole.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromNanogramsPerMole(double nanogramspermole)
#else
        public static MolarMass FromNanogramsPerMole(QuantityValue nanogramspermole)
#endif
        {
            double value = (double) nanogramspermole;
            return new MolarMass(value, MolarMassUnit.NanogramPerMole);
        }

        /// <summary>
        ///     Get MolarMass from PoundsPerMole.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarMass FromPoundsPerMole(double poundspermole)
#else
        public static MolarMass FromPoundsPerMole(QuantityValue poundspermole)
#endif
        {
            double value = (double) poundspermole;
            return new MolarMass(value, MolarMassUnit.PoundPerMole);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolarMassUnit" /> to <see cref="MolarMass" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MolarMass unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static MolarMass From(double value, MolarMassUnit fromUnit)
#else
        public static MolarMass From(QuantityValue value, MolarMassUnit fromUnit)
#endif
        {
            return new MolarMass((double)value, fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(MolarMassUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is MolarMass)) throw new ArgumentException("Expected type MolarMass.", nameof(obj));

            return CompareTo((MolarMass)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(MolarMass other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals($quantityName, double, ComparisonType) to provide the max allowed absolute or relative error.")]
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is MolarMass))
                return false;

            var objQuantity = (MolarMass)obj;
            return _value.Equals(objQuantity.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another MolarMass within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(MolarMass other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Compare equality to another MolarMass by specifying a max allowed difference.
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        /// </summary>
        /// <param name="other">Other quantity to compare to.</param>
        /// <param name="maxError">Max error allowed.</param>
        /// <returns>True if the difference between the two values is not greater than the specified max.</returns>
        [Obsolete("Please use the Equals(MolarMass, double, ComparisonType) overload. This method will be removed in a future version.")]
        public bool Equals(MolarMass other, MolarMass maxError)
        {
            return Math.Abs(_value - other.AsBaseNumericType(this.Unit)) <= maxError.AsBaseNumericType(this.Unit);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current MolarMass.</returns>
        public override int GetHashCode()
        {
            return new { Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(MolarMassUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this MolarMass to another MolarMass with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A MolarMass with the specified unit.</returns>
        public MolarMass ToUnit(MolarMassUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new MolarMass(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case MolarMassUnit.CentigramPerMole: return (_value/1e3) * 1e-2d;
                case MolarMassUnit.DecagramPerMole: return (_value/1e3) * 1e1d;
                case MolarMassUnit.DecigramPerMole: return (_value/1e3) * 1e-1d;
                case MolarMassUnit.GramPerMole: return _value/1e3;
                case MolarMassUnit.HectogramPerMole: return (_value/1e3) * 1e2d;
                case MolarMassUnit.KilogramPerMole: return (_value/1e3) * 1e3d;
                case MolarMassUnit.KilopoundPerMole: return (_value*0.45359237) * 1e3d;
                case MolarMassUnit.MegapoundPerMole: return (_value*0.45359237) * 1e6d;
                case MolarMassUnit.MicrogramPerMole: return (_value/1e3) * 1e-6d;
                case MolarMassUnit.MilligramPerMole: return (_value/1e3) * 1e-3d;
                case MolarMassUnit.NanogramPerMole: return (_value/1e3) * 1e-9d;
                case MolarMassUnit.PoundPerMole: return _value*0.45359237;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(MolarMassUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case MolarMassUnit.CentigramPerMole: return (baseUnitValue*1e3) / 1e-2d;
                case MolarMassUnit.DecagramPerMole: return (baseUnitValue*1e3) / 1e1d;
                case MolarMassUnit.DecigramPerMole: return (baseUnitValue*1e3) / 1e-1d;
                case MolarMassUnit.GramPerMole: return baseUnitValue*1e3;
                case MolarMassUnit.HectogramPerMole: return (baseUnitValue*1e3) / 1e2d;
                case MolarMassUnit.KilogramPerMole: return (baseUnitValue*1e3) / 1e3d;
                case MolarMassUnit.KilopoundPerMole: return (baseUnitValue/0.45359237) / 1e3d;
                case MolarMassUnit.MegapoundPerMole: return (baseUnitValue/0.45359237) / 1e6d;
                case MolarMassUnit.MicrogramPerMole: return (baseUnitValue*1e3) / 1e-6d;
                case MolarMassUnit.MilligramPerMole: return (baseUnitValue*1e3) / 1e-3d;
                case MolarMassUnit.NanogramPerMole: return (baseUnitValue*1e3) / 1e-9d;
                case MolarMassUnit.PoundPerMole: return baseUnitValue/0.45359237;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static MolarMass Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out MolarMass result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static MolarMassUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is KilogramPerMole
        /// </summary>
        [Obsolete("This is no longer used since we will instead use the quantity's Unit value as default.")]
        public static MolarMassUnit ToStringDefaultUnit { get; set; } = MolarMassUnit.KilogramPerMole;

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(Unit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(MolarMassUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of MolarMass
        /// </summary>
        public static MolarMass MaxValue => new MolarMass(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of MolarMass
        /// </summary>
        public static MolarMass MinValue => new MolarMass(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => MolarMass.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => MolarMass.BaseDimensions;
    }
}
