
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace RiskAssessment
{

using System;
    using System.Collections.Generic;
    
public partial class tbl_RiskAss_AssQuestion
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tbl_RiskAss_AssQuestion()
    {

        this.tbl_RiskAss_AssessmentResponse = new HashSet<tbl_RiskAss_AssessmentResponse>();

    }


    public int ID { get; set; }

    public int AssessmentTypeID { get; set; }

    public int QuestionID { get; set; }

    public int QuestionNumber { get; set; }

    public Nullable<int> SectionNumber { get; set; }



    public virtual tbl_RiskAss_Assessment tbl_RiskAss_Assessment { get; set; }

    public virtual tbl_RiskAss_Questions tbl_RiskAss_Questions { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<tbl_RiskAss_AssessmentResponse> tbl_RiskAss_AssessmentResponse { get; set; }

}

}
