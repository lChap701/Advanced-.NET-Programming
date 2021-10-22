<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
   <html>
      <h1>Sales Reps</h1> 
      <table border="3">
      <tr bgcolor="lightblue">
         <th>Rep Number</th> 
         <th>Rep Name</th> 
		<th>Rep Salary</th>  
      </tr>
      <xsl:for-each select="ArrayOfRep/Rep">
      <tr>
         <td>
            <xsl:value-of select="RNum" /> 
         </td>
         <td>
            <xsl:value-of select="RName" /> 
         </td>
		 <td>
            <xsl:value-of select="RSalary" /> 
         </td>	 
     </tr>
     </xsl:for-each>
     </table>
   </html>
</xsl:template>
</xsl:stylesheet>