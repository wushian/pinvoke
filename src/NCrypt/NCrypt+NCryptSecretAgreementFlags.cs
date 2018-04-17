﻿// Copyright (c) All contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PInvoke
{
    using System;

    /// <content>
    /// Contains the <see cref="NCryptSecretAgreementFlags"/> nested type.
    /// </content>
    public partial class NCrypt
    {
        /// <summary>
        /// The flags that may be passed to the <see cref="NCryptSecretAgreement(SafeKeyHandle, SafeKeyHandle, out SafeSecretHandle, NCryptSecretAgreementFlags)"/> method.
        /// </summary>
        [Flags]
        public enum NCryptSecretAgreementFlags
        {
            /// <summary>
            /// No flags.
            /// </summary>
            None = 0x0,

            /// <summary>
            /// Requests that the key service provider (KSP) not display any user interface. If the provider must display the UI to operate, the call fails and the KSP should set the NTE_SILENT_CONTEXT error code as the last error.
            /// </summary>
            NCRYPT_SILENT_FLAG = 0x00000040,
        }
    }
}
