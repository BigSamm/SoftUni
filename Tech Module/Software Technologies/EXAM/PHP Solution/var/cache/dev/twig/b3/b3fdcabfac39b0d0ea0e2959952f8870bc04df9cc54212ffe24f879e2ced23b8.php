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
        $__internal_ee74ed07581949a089e2398c396685c3fcc6a698f74225ebb2c839d3a2722804 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_ee74ed07581949a089e2398c396685c3fcc6a698f74225ebb2c839d3a2722804->enter($__internal_ee74ed07581949a089e2398c396685c3fcc6a698f74225ebb2c839d3a2722804_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/layout.html.twig"));

        $__internal_0511dcb0d9eaad5eddfd14ff3c7f2e9a1134b42e1fa0735b5d3290ed783a28c2 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0511dcb0d9eaad5eddfd14ff3c7f2e9a1134b42e1fa0735b5d3290ed783a28c2->enter($__internal_0511dcb0d9eaad5eddfd14ff3c7f2e9a1134b42e1fa0735b5d3290ed783a28c2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/layout.html.twig"));

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
        
        $__internal_ee74ed07581949a089e2398c396685c3fcc6a698f74225ebb2c839d3a2722804->leave($__internal_ee74ed07581949a089e2398c396685c3fcc6a698f74225ebb2c839d3a2722804_prof);

        
        $__internal_0511dcb0d9eaad5eddfd14ff3c7f2e9a1134b42e1fa0735b5d3290ed783a28c2->leave($__internal_0511dcb0d9eaad5eddfd14ff3c7f2e9a1134b42e1fa0735b5d3290ed783a28c2_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_8b90d290b2f17b5033ad9ebb8f0a68daafe5cd34f908593c4af317c5c6b4a176 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_8b90d290b2f17b5033ad9ebb8f0a68daafe5cd34f908593c4af317c5c6b4a176->enter($__internal_8b90d290b2f17b5033ad9ebb8f0a68daafe5cd34f908593c4af317c5c6b4a176_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_2e4c1725c826c55c7837621afe2dd64df80f8d3093aa1cd1c58d674d12e3b666 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_2e4c1725c826c55c7837621afe2dd64df80f8d3093aa1cd1c58d674d12e3b666->enter($__internal_2e4c1725c826c55c7837621afe2dd64df80f8d3093aa1cd1c58d674d12e3b666_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        
        $__internal_2e4c1725c826c55c7837621afe2dd64df80f8d3093aa1cd1c58d674d12e3b666->leave($__internal_2e4c1725c826c55c7837621afe2dd64df80f8d3093aa1cd1c58d674d12e3b666_prof);

        
        $__internal_8b90d290b2f17b5033ad9ebb8f0a68daafe5cd34f908593c4af317c5c6b4a176->leave($__internal_8b90d290b2f17b5033ad9ebb8f0a68daafe5cd34f908593c4af317c5c6b4a176_prof);

    }

    // line 10
    public function block_head($context, array $blocks = array())
    {
        $__internal_e2adadae01a3ca96d0559dd8099230e261b6b04f94dc6e76545b9af369ab6203 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_e2adadae01a3ca96d0559dd8099230e261b6b04f94dc6e76545b9af369ab6203->enter($__internal_e2adadae01a3ca96d0559dd8099230e261b6b04f94dc6e76545b9af369ab6203_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_e5b3a37ed77d956d0f89769b6fdd0cc7afc196c23a2aae663a8be42e3fe2815a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e5b3a37ed77d956d0f89769b6fdd0cc7afc196c23a2aae663a8be42e3fe2815a->enter($__internal_e5b3a37ed77d956d0f89769b6fdd0cc7afc196c23a2aae663a8be42e3fe2815a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        
        $__internal_e5b3a37ed77d956d0f89769b6fdd0cc7afc196c23a2aae663a8be42e3fe2815a->leave($__internal_e5b3a37ed77d956d0f89769b6fdd0cc7afc196c23a2aae663a8be42e3fe2815a_prof);

        
        $__internal_e2adadae01a3ca96d0559dd8099230e261b6b04f94dc6e76545b9af369ab6203->leave($__internal_e2adadae01a3ca96d0559dd8099230e261b6b04f94dc6e76545b9af369ab6203_prof);

    }

    // line 33
    public function block_body($context, array $blocks = array())
    {
        $__internal_dd6301005ecd2b30f1d1eaceb3175177dbd6f5fde5c838d3f74da62cf292ee71 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_dd6301005ecd2b30f1d1eaceb3175177dbd6f5fde5c838d3f74da62cf292ee71->enter($__internal_dd6301005ecd2b30f1d1eaceb3175177dbd6f5fde5c838d3f74da62cf292ee71_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_cf91c633b0eab81733491ff40befe8d009e983c97a51267efb648addfeaa5acd = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cf91c633b0eab81733491ff40befe8d009e983c97a51267efb648addfeaa5acd->enter($__internal_cf91c633b0eab81733491ff40befe8d009e983c97a51267efb648addfeaa5acd_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        
        $__internal_cf91c633b0eab81733491ff40befe8d009e983c97a51267efb648addfeaa5acd->leave($__internal_cf91c633b0eab81733491ff40befe8d009e983c97a51267efb648addfeaa5acd_prof);

        
        $__internal_dd6301005ecd2b30f1d1eaceb3175177dbd6f5fde5c838d3f74da62cf292ee71->leave($__internal_dd6301005ecd2b30f1d1eaceb3175177dbd6f5fde5c838d3f74da62cf292ee71_prof);

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
", "@Twig/layout.html.twig", "D:\\PHP Solution\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\TwigBundle\\Resources\\views\\layout.html.twig");
    }
}
