﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThuCommix.EntityFramework.Tests.Queries {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ExpectedQueryOutputs {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExpectedQueryOutputs() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ThuCommix.EntityFramework.Tests.Queries.ExpectedQueryOutputs", typeof(ExpectedQueryOutputs).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT FK_AnotherArtist_ID, FK_SecondArtist_ID, StatusCode, Id, Deleted, Version FROM ArtistStatisticValues artiststatisticvalues INNER JOIN Artist a0 ON a0.Id = artiststatisticvalues.FK_AnotherArtist_ID WHERE (a0.Alias IS NOT @p0)  ähnelt.
        /// </summary>
        internal static string Query_Inner_Join_For_Mandatory_Fields_Works {
            get {
                return ResourceManager.GetString("Query_Inner_Join_For_Mandatory_Fields_Works", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT FK_AnotherArtist_ID, FK_SecondArtist_ID, StatusCode, Id, Deleted, Version FROM ArtistStatisticValues artiststatisticvalues LEFT JOIN Artist a0 ON a0.Id = artiststatisticvalues.FK_SecondArtist_ID WHERE (a0.Alias IS NOT @p0)  ähnelt.
        /// </summary>
        internal static string Query_Left_Join_For_Non_Mandatory_Fields_Works {
            get {
                return ResourceManager.GetString("Query_Left_Join_For_Non_Mandatory_Fields_Works", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT FK_AnotherArtist_ID, FK_SecondArtist_ID, StatusCode, Id, Deleted, Version FROM ArtistStatisticValues artiststatisticvalues WHERE (artiststatisticvalues.Id = @p0)  ähnelt.
        /// </summary>
        internal static string Query_Max_Results_Are_Applied_When_Not_Null_False {
            get {
                return ResourceManager.GetString("Query_Max_Results_Are_Applied_When_Not_Null_False", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT FK_AnotherArtist_ID, FK_SecondArtist_ID, StatusCode, Id, Deleted, Version FROM ArtistStatisticValues artiststatisticvalues WHERE (artiststatisticvalues.Id = @p0) LIMIT 1  ähnelt.
        /// </summary>
        internal static string Query_Max_Results_Are_Applied_When_Not_Null_True {
            get {
                return ResourceManager.GetString("Query_Max_Results_Are_Applied_When_Not_Null_True", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT FK_AnotherArtist_ID, FK_SecondArtist_ID, StatusCode, Id, Deleted, Version FROM ArtistStatisticValues artiststatisticvalues INNER JOIN Artist a0 ON a0.Id = artiststatisticvalues.FK_AnotherArtist_ID WHERE (a0.Alias IS @p0) AND (a0.Biography IS @p1 AND a0.BirthDate IS NOT @p2)  ähnelt.
        /// </summary>
        internal static string Query_Multiple_ConditionGroups_And_Works {
            get {
                return ResourceManager.GetString("Query_Multiple_ConditionGroups_And_Works", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT FK_AnotherArtist_ID, FK_SecondArtist_ID, StatusCode, Id, Deleted, Version FROM ArtistStatisticValues artiststatisticvalues INNER JOIN Artist a0 ON a0.Id = artiststatisticvalues.FK_AnotherArtist_ID WHERE (a0.Alias IS @p0) OR (a0.Biography IS @p1 AND a0.BirthDate IS NOT @p2)  ähnelt.
        /// </summary>
        internal static string Query_Multiple_ConditionGroups_Or_Works {
            get {
                return ResourceManager.GetString("Query_Multiple_ConditionGroups_Or_Works", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT Name, Alias, BirthDate, DeathDate, WebLink, Biography, Note, Label, FK_AnotherArtist_ID, Id, Deleted, Version FROM Artist artist LEFT JOIN Artist a0 ON a0.Id = artist.FK_AnotherArtist_ID WHERE (a0.Alias = @p0)  ähnelt.
        /// </summary>
        internal static string Query_No_Sorting {
            get {
                return ResourceManager.GetString("Query_No_Sorting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT FK_AnotherArtist_ID, FK_SecondArtist_ID, StatusCode, Id, Deleted, Version FROM ArtistStatisticValues artiststatisticvalues WHERE (artiststatisticvalues.FK_SecondArtist_ID IS NOT @p0)  ähnelt.
        /// </summary>
        internal static string Query_Null_Checks_On_Foreign_Properties_Do_Not_Create_Joins {
            get {
                return ResourceManager.GetString("Query_Null_Checks_On_Foreign_Properties_Do_Not_Create_Joins", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT FK_AnotherArtist_ID, FK_SecondArtist_ID, StatusCode, Id, Deleted, Version FROM ArtistStatisticValues artiststatisticvalues WHERE (artiststatisticvalues.FK_SecondArtist_ID IS @p0)  ähnelt.
        /// </summary>
        internal static string Query_Operator_Equals_For_Null_Works {
            get {
                return ResourceManager.GetString("Query_Operator_Equals_For_Null_Works", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT FK_AnotherArtist_ID, FK_SecondArtist_ID, StatusCode, Id, Deleted, Version FROM ArtistStatisticValues artiststatisticvalues WHERE (artiststatisticvalues.Id = @p0)  ähnelt.
        /// </summary>
        internal static string Query_Operator_Equals_Works {
            get {
                return ResourceManager.GetString("Query_Operator_Equals_Works", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT FK_AnotherArtist_ID, FK_SecondArtist_ID, StatusCode, Id, Deleted, Version FROM ArtistStatisticValues artiststatisticvalues WHERE (artiststatisticvalues.Id &gt; @p0)  ähnelt.
        /// </summary>
        internal static string Query_Operator_GreaterThan_Works {
            get {
                return ResourceManager.GetString("Query_Operator_GreaterThan_Works", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT FK_AnotherArtist_ID, FK_SecondArtist_ID, StatusCode, Id, Deleted, Version FROM ArtistStatisticValues artiststatisticvalues WHERE (artiststatisticvalues.Id &gt;= @p0)  ähnelt.
        /// </summary>
        internal static string Query_Operator_GreaterThanOrEquals_Works {
            get {
                return ResourceManager.GetString("Query_Operator_GreaterThanOrEquals_Works", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT FK_AnotherArtist_ID, FK_SecondArtist_ID, StatusCode, Id, Deleted, Version FROM ArtistStatisticValues artiststatisticvalues WHERE (artiststatisticvalues.Id &lt; @p0)  ähnelt.
        /// </summary>
        internal static string Query_Operator_LessThan_Works {
            get {
                return ResourceManager.GetString("Query_Operator_LessThan_Works", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT FK_AnotherArtist_ID, FK_SecondArtist_ID, StatusCode, Id, Deleted, Version FROM ArtistStatisticValues artiststatisticvalues WHERE (artiststatisticvalues.Id &lt;= @p0)  ähnelt.
        /// </summary>
        internal static string Query_Operator_LessThanOrEquals_Works {
            get {
                return ResourceManager.GetString("Query_Operator_LessThanOrEquals_Works", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT FK_AnotherArtist_ID, FK_SecondArtist_ID, StatusCode, Id, Deleted, Version FROM ArtistStatisticValues artiststatisticvalues WHERE (artiststatisticvalues.FK_SecondArtist_ID IS NOT @p0)  ähnelt.
        /// </summary>
        internal static string Query_Operator_NotEquals_For_Null_Works {
            get {
                return ResourceManager.GetString("Query_Operator_NotEquals_For_Null_Works", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT FK_AnotherArtist_ID, FK_SecondArtist_ID, StatusCode, Id, Deleted, Version FROM ArtistStatisticValues artiststatisticvalues WHERE (artiststatisticvalues.Id != @p0)  ähnelt.
        /// </summary>
        internal static string Query_Operator_NotEquals_Works {
            get {
                return ResourceManager.GetString("Query_Operator_NotEquals_Works", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT Name, Alias, BirthDate, DeathDate, WebLink, Biography, Note, Label, FK_AnotherArtist_ID, Id, Deleted, Version FROM Artist artist LEFT JOIN Artist a0 ON a0.Id = artist.FK_AnotherArtist_ID WHERE (a0.Alias = @p0) ORDER BY a0.Alias DESC, artist.Name ASC, a0.Biography DESC  ähnelt.
        /// </summary>
        internal static string Query_Resolves_Multiple_Sorting_Expressions {
            get {
                return ResourceManager.GetString("Query_Resolves_Multiple_Sorting_Expressions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT Name, Alias, BirthDate, DeathDate, WebLink, Biography, Note, Label, FK_AnotherArtist_ID, Id, Deleted, Version FROM Artist artist LEFT JOIN Artist a0 ON a0.Id = artist.FK_AnotherArtist_ID WHERE (a0.Alias = @p0) ORDER BY a0.Alias ASC  ähnelt.
        /// </summary>
        internal static string Query_Resolves_Sorting_Expression_Ascending {
            get {
                return ResourceManager.GetString("Query_Resolves_Sorting_Expression_Ascending", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT Name, Alias, BirthDate, DeathDate, WebLink, Biography, Note, Label, FK_AnotherArtist_ID, Id, Deleted, Version FROM Artist artist LEFT JOIN Artist a0 ON a0.Id = artist.FK_AnotherArtist_ID WHERE (a0.Alias = @p0) ORDER BY a0.Alias DESC  ähnelt.
        /// </summary>
        internal static string Query_Resolves_Sorting_Expression_Descending {
            get {
                return ResourceManager.GetString("Query_Resolves_Sorting_Expression_Descending", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT FK_AnotherArtist_ID, FK_SecondArtist_ID, StatusCode, Id, Deleted, Version FROM ArtistStatisticValues artiststatisticvalues INNER JOIN Artist a0 ON a0.Id = artiststatisticvalues.FK_AnotherArtist_ID WHERE (a0.Alias IS @p0 AND a0.Biography IS NOT @p1)  ähnelt.
        /// </summary>
        internal static string Query_Same_FK_Access_Does_Not_Generate_Multiple_Joins {
            get {
                return ResourceManager.GetString("Query_Same_FK_Access_Does_Not_Generate_Multiple_Joins", resourceCulture);
            }
        }
    }
}
