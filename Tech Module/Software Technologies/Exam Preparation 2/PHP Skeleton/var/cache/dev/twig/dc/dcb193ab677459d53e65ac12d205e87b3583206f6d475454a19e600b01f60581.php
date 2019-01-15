<?php

/* :task:edit.html.twig */
class __TwigTemplate_15d8916e78eb1cbec3266efc0b6dd38c9e661c387928330071aa068da8837b16 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", ":task:edit.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_3ce425b9d5d2361519ef10b2134afc4e1a646b7ca38baa00c8919216f3d9b6c8 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_3ce425b9d5d2361519ef10b2134afc4e1a646b7ca38baa00c8919216f3d9b6c8->enter($__internal_3ce425b9d5d2361519ef10b2134afc4e1a646b7ca38baa00c8919216f3d9b6c8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":task:edit.html.twig"));

        $__internal_c0ea87a7beadccb936efe8f4c849d760b83bc6b9ae7b38d9f255e8a59e30d343 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c0ea87a7beadccb936efe8f4c849d760b83bc6b9ae7b38d9f255e8a59e30d343->enter($__internal_c0ea87a7beadccb936efe8f4c849d760b83bc6b9ae7b38d9f255e8a59e30d343_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":task:edit.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_3ce425b9d5d2361519ef10b2134afc4e1a646b7ca38baa00c8919216f3d9b6c8->leave($__internal_3ce425b9d5d2361519ef10b2134afc4e1a646b7ca38baa00c8919216f3d9b6c8_prof);

        
        $__internal_c0ea87a7beadccb936efe8f4c849d760b83bc6b9ae7b38d9f255e8a59e30d343->leave($__internal_c0ea87a7beadccb936efe8f4c849d760b83bc6b9ae7b38d9f255e8a59e30d343_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_a47b72cb4e57ba23ca1966b4f361bce01aa8efe6464f9b14d26f7f5ca5b45091 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_a47b72cb4e57ba23ca1966b4f361bce01aa8efe6464f9b14d26f7f5ca5b45091->enter($__internal_a47b72cb4e57ba23ca1966b4f361bce01aa8efe6464f9b14d26f7f5ca5b45091_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_500f784cbe94643015ac3cd5d09fa6dfb5f843d5b96ba1248c659811740a29a5 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_500f784cbe94643015ac3cd5d09fa6dfb5f843d5b96ba1248c659811740a29a5->enter($__internal_500f784cbe94643015ac3cd5d09fa6dfb5f843d5b96ba1248c659811740a29a5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "    <header>
        <h3>Edit Task</h3>
    </header>

    <form method=\"post\">
        <div>
            <label class=\"desc\" for=\"title\">Title</label>
            <div>
                <input id=\"title\" name=\"task[title]\" type=\"text\" class=\"field text fn\" size=\"8\" tabindex=\"1\" value=\"";
        // line 12
        echo twig_escape_filter($this->env, $this->getAttribute(($context["task"] ?? $this->getContext($context, "task")), "title", array()), "html", null, true);
        echo "\" autofocus>
            </div>
        </div>

        <div>
            <fieldset>
                <legend class=\"desc\">
                    Status
                </legend>

                <div>
                    <div>
                        <input id=\"status1\" name=\"task[status]\" type=\"radio\" value=\"Open\" tabindex=\"2\" ";
        // line 24
        echo ((($this->getAttribute(($context["task"] ?? $this->getContext($context, "task")), "status", array()) == "Open")) ? ("checked") : (""));
        echo ">
                        <label class=\"choice\" for=\"status1\">Open</label>
                    </div>
                    <div>
                        <input id=\"status2\" name=\"task[status]\" type=\"radio\" value=\"In Progress\" tabindex=\"3\" ";
        // line 28
        echo ((($this->getAttribute(($context["task"] ?? $this->getContext($context, "task")), "status", array()) == "In Progress")) ? ("checked") : (""));
        echo ">
                        <label class=\"choice\" for=\"status2\">In Progress</label>
                    </div>
                    <div>
                        <input id=\"status3\" name=\"task[status]\" type=\"radio\" value=\"Finished\" tabindex=\"4\" ";
        // line 32
        echo ((($this->getAttribute(($context["task"] ?? $this->getContext($context, "task")), "status", array()) == "Finished")) ? ("checked") : (""));
        echo ">
                        <label class=\"choice\" for=\"status3\">Finished</label>
                    </div>
                </div>
            </fieldset>
        </div>

        <div>
            <div>
                <input class=\"button\" type=\"submit\" value=\"Submit\">
                <a class=\"button cancel\" href=\"/\">Cancel</a>
            </div>
        </div>

        ";
        // line 46
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
";
        
        $__internal_500f784cbe94643015ac3cd5d09fa6dfb5f843d5b96ba1248c659811740a29a5->leave($__internal_500f784cbe94643015ac3cd5d09fa6dfb5f843d5b96ba1248c659811740a29a5_prof);

        
        $__internal_a47b72cb4e57ba23ca1966b4f361bce01aa8efe6464f9b14d26f7f5ca5b45091->leave($__internal_a47b72cb4e57ba23ca1966b4f361bce01aa8efe6464f9b14d26f7f5ca5b45091_prof);

    }

    public function getTemplateName()
    {
        return ":task:edit.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  105 => 46,  88 => 32,  81 => 28,  74 => 24,  59 => 12,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
    <header>
        <h3>Edit Task</h3>
    </header>

    <form method=\"post\">
        <div>
            <label class=\"desc\" for=\"title\">Title</label>
            <div>
                <input id=\"title\" name=\"task[title]\" type=\"text\" class=\"field text fn\" size=\"8\" tabindex=\"1\" value=\"{{ task.title }}\" autofocus>
            </div>
        </div>

        <div>
            <fieldset>
                <legend class=\"desc\">
                    Status
                </legend>

                <div>
                    <div>
                        <input id=\"status1\" name=\"task[status]\" type=\"radio\" value=\"Open\" tabindex=\"2\" {{ task.status == 'Open' ? 'checked' : '' }}>
                        <label class=\"choice\" for=\"status1\">Open</label>
                    </div>
                    <div>
                        <input id=\"status2\" name=\"task[status]\" type=\"radio\" value=\"In Progress\" tabindex=\"3\" {{ task.status == 'In Progress' ? 'checked' : '' }}>
                        <label class=\"choice\" for=\"status2\">In Progress</label>
                    </div>
                    <div>
                        <input id=\"status3\" name=\"task[status]\" type=\"radio\" value=\"Finished\" tabindex=\"4\" {{ task.status == 'Finished' ? 'checked' : '' }}>
                        <label class=\"choice\" for=\"status3\">Finished</label>
                    </div>
                </div>
            </fieldset>
        </div>

        <div>
            <div>
                <input class=\"button\" type=\"submit\" value=\"Submit\">
                <a class=\"button cancel\" href=\"/\">Cancel</a>
            </div>
        </div>

        {{ form_row(form._token) }}
    </form>
{% endblock %}", ":task:edit.html.twig", "D:\\PHP Skeleton 2\\app/Resources\\views/task/edit.html.twig");
    }
}
