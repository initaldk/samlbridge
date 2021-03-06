﻿/*
 * Copyright (C) 2006-2010 Google Inc.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 */

using System;
using System.Collections.Generic;
using System.Web;



namespace SAMLServices
{
    /// <summary>
    /// Object which has values associated with each SAML artifact
    /// </summary>
    public class SamlArtifactCacheEntry
    {
        private readonly string subject;
        private readonly string authNRequestId;

        public SamlArtifactCacheEntry(string subject, string authNRequestId)
        {
            this.subject = subject;
            this.authNRequestId = authNRequestId;
        }

        public string Subject
        {
            get
            {
                return subject;
            }
        }

        public string AuthNRequestId
        {
            get
            {
                return authNRequestId;
            }
        }
    }
}
