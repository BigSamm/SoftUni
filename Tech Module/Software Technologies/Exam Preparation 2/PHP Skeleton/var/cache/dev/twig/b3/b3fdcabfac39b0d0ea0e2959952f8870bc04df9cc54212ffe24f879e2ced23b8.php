<?php

/* @Twig/layout.html.twig */
class __TwigTemplate_0ef46ff3e00be850b375145c4de69a72941605b1b30816a42d1a36aa92bc080f extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'head' => array($this, 'block_head'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_054e5bd3ab77ce5079235c4234c417cdaee325a0978588ff8f8f2b7d838f75ea = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_054e5bd3ab77ce5079235c4234c417cdaee325a0978588ff8f8f2b7d838f75ea->enter($__internal_054e5bd3ab77ce5079235c4234c417cdaee325a0978588ff8f8f2b7d838f75ea_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/layout.html.twig"));

        $__internal_132a9e61fd91630affaa1a302f945c5edd5514f3048d785055fe26778feb4ed4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_132a9e61fd91630affaa1a302f945c5edd5514f3048d785055fe26778feb4ed4->enter($__internal_132a9e61fd91630affaa1a302f945c5edd5514f3048d785055fe26778feb4ed4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/layout.html.twig"));

        // line 1
        echo "<!DOCTYPE html>
<html>
    <head>
        <meta charset=\"";
        // line 4
        echo twig_escape_filter($this->env, $this->env->getCharset(), "html", null, true);
        echo "\" />
        <meta name=\"robots\" content=\"noindex,nofollow\" />
        <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\" />
        <title>";
        // line 7
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
        <link rel=\"icon\" type=\"image/png\" href=\"";
        // line 8
        echo twig_include($this->env, $context, "@Twig/images/favicon.png.base64");
        echo "\">
        <style>";
        // line 9
        echo twig_include($this->env, $context, "@Twig/exception.css.twig");
        echo "</style>
        ";
        // line 10
        $this->displayBlock('head', $context, $blocks);
        // line 11
        echo "    </head>
    <body>
        <header>
            <div class=\"container\">
                <h1 class=\"logo\">";
        // line 15
        echo twig_include($this->env, $context, "@Twig/images/symfony-logo.svg");
        echo " Symfony Exception</h1>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/doc\">
                        <span class=\"icon\">";
        // line 19
        echo twig_include($this->env, $context, "@Twig/images/icon-book.svg");
        echo "</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Docs
                    </a>
                </div>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/support\">
                        <span class=\"icon\">";
        // line 26
        echo twig_include($this->env, $context, "@Twig/images/icon-support.svg");
        echo "</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Support
                    </a>
                </div>
            </div>
        </header>

        ";
        // line 33
        $this->displayBlock('body', $context, $blocks);
        // line 34
        echo "        ";
        echo twig_include($this->env, $context, "@Twig/base_js.html.twig");
        echo "
    </body>
</html>
";
        
        $__internal_054e5bd3ab77ce5079235c4234c417cdaee325a0978588ff8f8f2b7d838f75ea->leave($__internal_054e5bd3ab77ce5079235c4234c417cdaee325a0978588ff8f8f2b7d838f75ea_prof);

        
        $__internal_132a9e61fd91630affaa1a302f945c5edd5514f3048d785055fe26778feb4ed4->leave($__internal_132a9e61fd91630affaa1a302f945c5edd5514f3048d785055fe26778feb4ed4_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_6bb9acf30aade4b99a7708eb37bae7f69e178b87f771e38315a095ae8531cca5 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_6bb9acf30aade4b99a7708eb37bae7f69e178b87f771e38315a095ae8531cca5->enter($__internal_6bb9acf30aade4b99a7708eb37bae7f69e178b87f771e38315a095ae8531cca5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_b71355031c7d81658d9e67957f9ba43da29295a3e7a5e00978fbbbdf1a4937f8 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b71355031c7d81658d9e67957f9ba43da29295a3e7a5e00978fbbbdf1a4937f8->enter($__internal_b71355031c7d81658d9e67957f9ba43da29295a3e7a5e00978fbbbdf1a4937f8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        
        $__internal_b71355031c7d81658d9e67957f9ba43da29295a3e7a5e00978fbbbdf1a4937f8->leave($__internal_b71355031c7d81658d9e67957f9ba43da29295a3e7a5e00978fbbbdf1a4937f8_prof);

        
        $__internal_6bb9acf30aade4b99a7708eb37bae7f69e178b87f771e38315a095ae8531cca5->leave($__internal_6bb9acf30aade4b99a7708eb37bae7f69e178b87f771e38315a095ae8531cca5_prof);

    }

    // line 10
    public function block_head($context, array $blocks = array())
    {
        $__internal_ad771c482a15ce0e757579833f0fb369e99f2d2dd5b2ec6427168270342b1eb4 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_ad771c482a15ce0e757579833f0fb369e99f2d2dd5b2ec6427168270342b1eb4->enter($__internal_ad771c482a15ce0e757579833f0fb369e99f2d2dd5b2ec6427168270342b1eb4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_ca25aaced7986b04a693f7c5d4c2e688650f6527546033b4adcfd7f2c31ab580 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ca25aaced7986b04a693f7c5d4c2e688650f6527546033b4adcfd7f2c31ab580->enter($__internal_ca25aaced7986b04a693f7c5d4c2e688650f6527546033b4adcfd7f2c31ab580_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        
        $__internal_ca25aaced7986b04a693f7c5d4c2e688650f6527546033b4adcfd7f2c31ab580->leave($__internal_ca25aaced7986b04a693f7c5d4c2e688650f6527546033b4adcfd7f2c31ab580_prof);

        
        $__internal_ad771c482a15ce0e757579833f0fb369e99f2d2dd5b2ec6427168270342b1eb4->leave($__internal_ad771c482a15ce0e757579833f0fb369e99f2d2dd5b2ec6427168270342b1eb4_prof);

    }

    // line 33
    public function block_body($context, array $blocks = array())
    {
        $__internal_808a4c65eb035c9426842a6962794d2522de7c5ba8e17c006380b0595a016f52 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_808a4c65eb035c9426842a6962794d2522de7c5ba8e17c006380b0595a016f52->enter($__internal_808a4c65eb035c9426842a6962794d2522de7c5ba8e17c006380b0595a016f52_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_05a041d0726dbf6361f7ab6bd1e0f6201b0cbe311c8b7a19aca74c6f2527d8f6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_05a041d0726dbf6361f7ab6bd1e0f6201b0cbe311c8b7a19aca74c6f2527d8f6->enter($__internal_05a041d0726dbf6361f7ab6bd1e0f6201b0cbe311c8b7a19aca74c6f2527d8f6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        
        $__internal_05a041d0726dbf6361f7ab6bd1e0f6201b0cbe311c8b7a19aca74c6f2527d8f6->leave($__internal_05a041d0726dbf6361f7ab6bd1e0f6201b0cbe311c8b7a19aca74c6f2527d8f6_prof);

        
        $__internal_808a4c65eb035c9426842a6962794d2522de7c5ba8e17c006380b0595a016f52->leave($__internal_808a4c65eb035c9426842a6962794d2522de7c5ba8e17c006380b0595a016f52_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/layout.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  137 => 33,  120 => 10,  103 => 7,  88 => 34,  86 => 33,  76 => 26,  66 => 19,  59 => 15,  53 => 11,  51 => 10,  47 => 9,  43 => 8,  39 => 7,  33 => 4,  28 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("<!DOCTYPE html>
<html>
    <head>
        <meta charset=\"{{ _charset }}\" />
        <meta name=\"robots\" content=\"noindex,nofollow\" />
        <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\" />
        <title>{% block title %}{% endblock %}</title>
        <link rel=\"icon\" type=\"image/png\" href=\"{{ include('@Twig/images/favicon.png.base64') }}\">
        <style>{{ include('@Twig/exception.css.twig') }}</style>
        {% block head %}{% endblock %}
    </head>
    <body>
        <header>
            <div class=\"container\">
                <h1 class=\"logo\">{{ include('@Twig/images/symfony-logo.svg') }} Symfony Exception</h1>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/doc\">
                        <span class=\"icon\">{{ include('@Twig/images/icon-book.svg') }}</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Docs
                    </a>
                </div>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/support\">
                        <span class=\"icon\">{{ include('@Twig/images/icon-support.svg') }}</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Support
                    </a>
                </div>
            </div>
        </header>

        {% block body %}{% endblock %}
        {{ include('@Twig/base_js.html.twig') }}
    </body>
</html>
", "@Twig/layout.html.twig", "D:\\PHP Skeleton 2\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\TwigBundle\\Resources\\views\\layout.html.twig");
    }
}
