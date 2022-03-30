// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace RoofFunction
{
    public class RoofFunctionOutputs: ResultsBase
    {
		/// <summary>
		/// The total roofing area.
		/// </summary>
		[JsonProperty("Total Roof Area")]
		public double TotalRoofArea {get; set;}



        /// <summary>
        /// Construct a RoofFunctionOutputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public RoofFunctionOutputs() : base()
        {

        }


        /// <summary>
        /// Construct a RoofFunctionOutputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public RoofFunctionOutputs(double totalRoofArea): base()
        {
			this.TotalRoofArea = totalRoofArea;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}