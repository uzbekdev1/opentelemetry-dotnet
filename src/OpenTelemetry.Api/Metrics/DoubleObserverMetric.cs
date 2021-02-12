// <copyright file="DoubleObserverMetric.cs" company="OpenTelemetry Authors">
// Copyright The OpenTelemetry Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using System;
using System.Collections.Generic;

namespace OpenTelemetry.Metrics
{
    /// <summary>
    /// Observer instrument for Double values.
    /// </summary>
    [Obsolete("Metrics API/SDK is not recommended for production. See https://github.com/open-telemetry/opentelemetry-dotnet/issues/1501 for more information on metrics support.")]
    public abstract class DoubleObserverMetric
    {
        /// <summary>
        /// Observes a value.
        /// </summary>
        /// <param name="value">value to observe.</param>
        /// <param name="labelset">The labelset associated with this value.</param>
        public abstract void Observe(double value, LabelSet labelset);

        /// <summary>
        /// Observes a value.
        /// </summary>
        /// <param name="value">value to observe.</param>
        /// <param name="labels">The labels or dimensions associated with this value.</param>
        public abstract void Observe(double value, IEnumerable<KeyValuePair<string, string>> labels);
    }
}