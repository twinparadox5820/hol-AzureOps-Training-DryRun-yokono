using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureOps_SampleApp.Pages
{
    public class MemoryPercentageUp : PageModel
    {
        private readonly ILogger<MemoryPercentageUp> _logger;

        public MemoryPercentageUp(ILogger<MemoryPercentageUp> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // �������g�p�ʂ��Ӑ}�I�ɏグ��
            var list = new List<string>();
            // ���O�ɏo�͂����
            _logger.LogInformation("�������g�p�����Ӑ}�I�ɏ㏸�����܂�");
            while (true)
            {
                list.Add("�����������������������������������Ă�");
            }
        }
    }
}
